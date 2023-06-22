function shoppingCartTemplate(html) {
    return html`
    <!DOCTYPE html>
<html>
   <head>
      <!-- Basic -->
      <meta charset="utf-8" />
      <meta http-equiv="X-UA-Compatible" content="IE=edge" />
      <!-- Mobile Metas -->
      <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
      <!-- Site Metas -->
      <meta name="keywords" content="" />
      <meta name="description" content="" />
      <meta name="author" content="" />
      <link rel="shortcut icon" href="src/images/favicon.png" type="">
      <title>Autoportal - Contacts</title>
      <!-- bootstrap core css -->
      <link rel="stylesheet" type="text/css" href="src/css/bootstrap.css" />
      <!-- font awesome style -->
      <link href="src/css/font-awesome.min.css" rel="stylesheet" />
      <!-- Custom styles for this template -->
      <link href="src/css/style.css" rel="stylesheet" />
      <!-- responsive style -->
      <link href="src/css/responsive.css" rel="stylesheet" />
   </head>
   <body class="sub_page" onload="displayItems()">
      <div class="hero_area">
         <!-- header section strats -->
         <header class="header_section">
               <div class="container">
                  <nav class="navbar navbar-expand-lg custom_nav-container ">
                     <a class="navbar-brand" href="/"><img width="400" src="src/images/wrench.png" alt="#"/></a>
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
                           
                        </ul>
                     </div>
                  </nav>
               </div>
            </header>
         <!-- end header section -->
      </div>
      <!-- inner page section -->
      <section class="inner_page_head">
         <div class="container_fuild">
            <div class="row">
               <div class="col-md-12">
                  <div class="full">
                     <h3>Shopping Cart</h3>
                  </div>
               </div>
            </div>
         </div>
      </section>
      <!-- end inner page section -->
      <!-- why section -->
      <section class="why_section layout_padding">
         <div class="container" id="cart-start">
             <h3 style="text-align: center; margin: 5rem; font-size: 3rem;" id="empty-shopping-cart-message">Shopping cart is empty!</h3>
         </div>
      </section>
      <!-- end why section -->
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
                           <p><strong>ADDRESS:</strong> Sofia, Boulevard Alexandar Malinov 45</p>
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
      <script src="src/js/jquery-3.4.1.min.js"></script>
      <!-- popper js -->
      <script src="src/js/popper.min.js"></script>
      <!-- bootstrap js -->
      <script src="src/js/bootstrap.js"></script>
      <!-- custom js -->
      <script src="src/js/custom.js"></script>
      <script src="src/js/shoppingCart.js"></script>
   </body>
</html>
    `
}

export default shoppingCartTemplate;