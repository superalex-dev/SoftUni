import page from "page";

function catalogTemplate(html, querySnapshot, ctx) {

    const arr = [];

    querySnapshot.forEach((doc) => {
        arr.push({id: doc.id, ...doc.data()})
    });

    function itemDetailsHandler(id) {
        return function () {
            page.redirect('/catalog/' + id)
        }
    }

    const itemCatalogTemplate = (doc) => html`
    <div @click=${itemDetailsHandler(doc.id)} id=${doc.id}>
        <h2>${doc.title}</h2>
        <p>${doc.description}</p>
    </div>
    `

    return  html`
    ${arr.map((doc) => itemCatalogTemplate(doc))}
      <div class="hero_area">
         <!-- header section strats -->
         <header class="header_section">
               <div class="container">
                  <nav class="navbar navbar-expand-lg custom_nav-container ">
                     <a class="navbar-brand" href="/"><img width="400" src="src/images/wrench.png" alt="/"/></a>
                     <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                     <span class=""> </span>
                     </button>
                     <div class="collapse navbar-collapse" id="navbarSupportedContent">
                        <ul class="navbar-nav">
                           <li class="nav-item active">
                              <a class="nav-link" href="/">Home <span class="sr-only">(current)</span></a>
                           </li>
                           <li class="nav-item">
                              <a class="nav-link" href="/catalog">Products</a>
                           </li>
                           <li class="nav-item">
                              <a class="nav-link" href="/about">Contact</a>
                           </li>
                           <li class="nav-item">
                              <a class="nav-link" href="/shopping-cart">
                                 <svg version="1.1" id="Capa_1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" x="0px" y="0px" viewBox="0 0 456.029 456.029" style="enable-background:new 0 0 456.029 456.029;" xml:space="preserve">
                                    <g>
                                       <g>
                                          <path d="M345.6,338.862c-29.184,0-53.248,23.552-53.248,53.248c0,29.184,23.552,53.248,53.248,53.248
                                             c29.184,0,53.248-23.552,53.248-53.248C398.336,362.926,374.784,338.862,345.6,338.862z" />
                                       </g>
                                    </g>
                                    <g>
                                       <g>
                                          <path d="M439.296,84.91c-1.024,0-2.56-0.512-4.096-0.512H112.64l-5.12-34.304C104.448,27.566,84.992,10.67,61.952,10.67H20.48
                                             C9.216,10.67,0,19.886,0,31.15c0,11.264,9.216,20.48,20.48,20.48h41.472c2.56,0,4.608,2.048,5.12,4.608l31.744,216.064
                                             c4.096,27.136,27.648,47.616,55.296,47.616h212.992c26.624,0,49.664-18.944,55.296-45.056l33.28-166.4
                                             C457.728,97.71,450.56,86.958,439.296,84.91z" />
                                       </g>
                                    </g>
                                    <g>
                                       <g>
                                          <path d="M215.04,389.55c-1.024-28.16-24.576-50.688-52.736-50.688c-29.696,1.536-52.224,26.112-51.2,55.296
                                             c1.024,28.16,24.064,50.688,52.224,50.688h1.024C193.536,443.31,216.576,418.734,215.04,389.55z" />
                                       </g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                    <g>
                                    </g>
                                 </svg>
                              </a>
                           </li>
                        </ul>
                     </div>
                  </nav>
               </div>
            </header>
         <!-- end header section -->
      </div>
      <section class="inner_page_head">
            <div class="container_fuild">
               <div class="row">
                  <div class="col-md-12">
                     <div class="full">
                        <h3>Our products</h3>
                     </div>
                  </div>
               </div>
            </div>
         </section>
      <!-- product section -->
      <section class="product_section layout_padding">
         <div class="container">
            <div class="row">
               <div class="col-sm-6 col-md-4 col-lg-3">
                  <div class="box" id="product1">
                        <div class="option_container">
                              <div class="options" onclick="addToCart(499)">
                                    <a href="" class="option1">
                                    Add To Cart
                                    </a>
                                 </div>
                           </div>
                     <div class="img-box" id="works">
                        <img src="src/images/AC-Compressor.PNG" alt="">
                     </div>
                     <div class="detail-box">
                        <h5>
                           AC Pump
                        </h5>
                        <h6>
                           $499
                        </h6>
                     </div>
                  </div>
               </div>
               <div class="col-sm-6 col-md-4 col-lg-3">
                  <div class="box" id="product2">
                     <div class="option_container">
                        <div class="options" onclick="addToCart(80)">
                           <a href="" class="option1">
                           Add To Cart
                           </a>
                        </div>
                     </div>
                     <div class="img-box">
                        <img src="src/images/headlight.png" alt="">
                     </div>
                     <div class="detail-box">
                        <h5>
                           HeadLight
                        </h5>
                        <h6>
                           $80
                        </h6>
                     </div>
                  </div>
               </div>
               <div class="col-sm-6 col-md-4 col-lg-3">
                  <div class="box" id="product3">
                     <div class="option_container">
                        <div class="options" onclick="addToCart(8999)">
                           <a href="" class="option1">
                           Add To Cart
                           </a>
                        </div>
                     </div>
                     <div class="img-box">
                        <img src="src/images/engine.png" alt="">
                     </div>
                     <div class="detail-box">
                        <h5>
                           Engine
                        </h5>
                        <h6>
                           $8999
                        </h6>
                     </div>
                  </div>
               </div>
               <div class="col-sm-6 col-md-4 col-lg-3">
                  <div class="box" id="product4">
                     <div class="option_container">
                        <div class="options" onclick="addToCart(149)">
                           <a href="" class="option1">
                           Add To Cart
                           </a>
                        </div>
                     </div>
                     <div class="img-box">
                        <img src="src/images/alternator.png" alt="">
                     </div>
                     <div class="detail-box">
                        <h5>
                           Alternator
                        </h5>
                        <h6>
                           $149
                        </h6>
                     </div>
                  </div>
               </div>
               <div class="col-sm-6 col-md-4 col-lg-3">
                  <div class="box" id="product5">
                     <div class="option_container">
                        <div class="options" onclick="addToCart(99)">
                           <a  class="option1">
                           Add To Cart
                           </a>
                        </div>
                     </div>
                     <div class="img-box">
                        <img src="src/images/battery.png" alt="">
                     </div>
                     <div class="detail-box">
                        <h5 style="color: black;">
                           Battery
                        </h5>
                        <h6>
                           $99
                        </h6>
                     </div>
                  </div>
               </div>
               <div class="col-sm-6 col-md-4 col-lg-3">
                  <div class="box" id="product6">
                     <div class="option_container">
                         <div class="options" onclick="addToCart(99)">
                           <a href="" class="option1">
                           Add To Cart
                           </a>
                        </div>
                     </div>
                     <div class="img-box">
                        <img src="src/images/door.png" alt="">
                     </div>
                     <div class="detail-box">
                        <h5 style="color: black">
                           Door
                        </h5>
                        <h6>
                           $249
                        </h6>
                     </div>
                  </div>
               </div>
               <div class="col-sm-6 col-md-4 col-lg-3">
                  <div class="box" id="product7">
                     <div class="option_container">
                        <div class="options" onclick="addToCart(119)">
                           <a href="" class="option1">
                           Add To Cart
                           </a>
                        </div>
                     </div>
                     <div class="img-box">
                        <img src="src/images/steering-wheel.png" alt="">
                     </div>
                     <div class="detail-box">
                        <h5>
                           Steering Wheel
                        </h5>
                        <h6>
                           $119
                        </h6>
                     </div>
                  </div>
               </div>
               <div class="col-sm-6 col-md-4 col-lg-3">
                  <div class="box" id="product8">
                     <div class="option_container">
                        <div class="options" onclick="addToCart(109)">
                           <a href="" class="option1">
                           Add To Cart
                           </a>
                        </div>
                     </div>
                     <div class="img-box">
                        <img src="src/images/starter.png" alt="">
                     </div>
                     <div class="detail-box">
                        <h5>
                           Starter
                        </h5>
                        <h6>
                           $109
                        </h6>
                     </div>
                  </div>
               </div>
              
               
         </div>
      </section>
      <!-- end product section -->
      <!-- footer section -->
      <footer>
            <div class="container">
               <div class="row">
                  <div class="col-md-4">
                     <div class="full">
                        <div class="logo_footer">
                           <a href="#"><img width="210" src="src/images/wrench.png" alt="#" /></a>
                        </div>
                        <div class="information_f">
                           <p><strong>ADDRESS:</strong> Sofia, Street Sokerez 69</p>
                           <p><strong>TELEPHONE:</strong> 088 888 8888</p>
                           <p><strong>EMAIL:</strong> autoportal@gmail.com</p>
                        </div>
                     </div>
                  </div>
                  <div class="col-md-8">
                     <div class="row">
                        <div class="col-md-7">
                           <div class="row">
                              <div class="col-md-6">
                                 <div class="widget_menu" style="padding-top: 3rem; margin-left: 10rem;">
                                    <h3>Menu</h3>
                                    <ul>
                                       <li><a href="/">Home</a></li>
                                       <li><a href="/about">Contact</a></li>
                                       <li><a href="/catalog">Products</a></li>
                                    </ul>
                                 </div>
                              </div>
                           </div>
                        </div>
                     </div>
                  </div>
               </div>
            </div>
         </footer>
         <div class="cpy_">
            </div>
      <!-- footer section -->
      <!-- jQery -->
      <script src="js/jquery-3.4.1.min.js"></script>
      <!-- popper js -->
      <script src="js/popper.min.js"></script>
      <!-- bootstrap js -->
      <script src="js/bootstrap.js"></script>
      <!-- custom js -->
      <script src="js/custom.js"></script>
      <script src="js/shoppingCart.js"></script>
    `
}

export default catalogTemplate;