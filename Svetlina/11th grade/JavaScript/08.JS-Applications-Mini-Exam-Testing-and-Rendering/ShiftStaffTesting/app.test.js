//@ts-check
// Note: Don't forget to run 'npm install', because this app has dependencies 
// and also configure your mocha tests in the launch.json file.
// Check if the localhost is the same as the one that your computer is using

const { chromium } = require('playwright-chromium');
const { expect } = require('chai');

const host = 'http://localhost:5500'; // Application host (NOT service host - that can be anything)
const DEBUG = false;

function json(data) {
    return {
        status: 200,
        headers: {
            'Access-Control-Allow-Origin': '*',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
    };
}

let browser;
let context;
let page;

let testData = {
    "2d5ae478-87c7-45fa-acf9-f04aa4724421": {
        person: 'Maya',
        _id: '2d5ae478-87c7-45fa-acf9-f04aa4724421'
    },
    "8d5ae438-87c5-45fa-acf6-f04aa4721424": {
        person: 'Jef',
        _id: '8d5ae438-87c5-45fa-acf6-f04aa4721424'
    },
}

describe('E2E tests', function() {
    if (DEBUG) {
        this.timeout(120000);
    } else {
        this.timeout(6000);
    }

    before(async() => {
        if (DEBUG) {
            browser = await chromium.launch({ headless: false, slowMo: 2500 });
        } else {
            browser = await chromium.launch();
        }
    });

    after(async() => {
        await browser.close();
    });

    beforeEach(async() => {
        context = await browser.newContext();
        page = await context.newPage();
    });

    afterEach(async() => {
        await page.close();
        await context.close();
    });

    describe('Catalog', () => {
        it('load all names', async() => {
            await page.goto(`${host}/index.html`);

            await page.click('#btnLoad');

            await page.waitForSelector('#staff tr');

            const names = await page.$$eval('#staff tr', (rows) => {
                return Array.from(rows, (row) => row.querySelector('td:first-child').textContent.trim());
            });

            expect(names.length).to.be.above(0);
        });
    });

});
