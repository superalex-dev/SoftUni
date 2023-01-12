const provider = require("../MusicProvider/musicProvider");
const {assert} = require("chai");

describe("Music Provider Tests", () => {

    it("should return undefined when songName is not in songsCollection", () => {
        assert.isUndefined(provider(['Imagine', 'One', 'Hey Jude', 'Billie Jean'], ['Hey Jude'], 'Respect'));
    });

    it("should return the list of played songs when songName is in songsCollection and not in playedSongs", () => {
        assert.equal(provider(['Imagine', 'One', 'Hey Jude', 'Billie Jean', 'Respect'], ['Hey Jude'], 'Respect'), "Played songs: Hey Jude, Respect");
    });

    it("should return 'Play On Repeat {songName}' when songName is in both songsCollection and playedSongs", () => {
        assert.equal(provider(['Imagine', 'One', 'Hey Jude', 'Respect', 'Billie Jean'], ['Hey Jude', 'Respect'], 'Respect'), "Play On Repeat Respect");
    });
});