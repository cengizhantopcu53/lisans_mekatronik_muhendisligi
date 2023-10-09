<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnaSayfa.aspx.cs" Inherits="Odev6_TicariAlisverisSitesi.AnaSayfa" %>

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8">
        <title>Robotistan | Elektronik Malzeme Marketi Online Satış</title>
        <meta content="width=device-width, initial-scale=1.0" name="viewport">
        <meta content="eCommerce HTML Template Free Download" name="keywords">
        <meta content="eCommerce HTML Template Free Download" name="description">

        <!-- Favicon -->
        <link href="img/favicon.ico" rel="icon">

        <!-- Google Fonts -->
        <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400|Source+Code+Pro:700,900&display=swap" rel="stylesheet">

        <!-- CSS Libraries -->
        <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" rel="stylesheet">
        <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.10.0/css/all.min.css" rel="stylesheet">
        <link href="Dosyalar/lib/slick/slick.css" rel="stylesheet">
        <link href="Dosyalar/lib/slick/slick-theme.css" rel="stylesheet">

        <!-- Template Stylesheet -->
        <link href="Dosyalar/css/style.css" rel="stylesheet">
        <style type="text/css">
            .auto-style1 {
                width: 88%;
                height: 294px;
            }
        </style>
    </head>

    <body>
        <!-- Top bar Start -->
        <div class="top-bar">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-sm-6">
                        <i class="fa fa-envelope"></i>
                        robotistan@gmail.com
                    </div>
                    <div class="col-sm-6">
                        <i class="fa fa-phone-alt"></i>
                        +0850 567 69 34
                    </div>
                </div>
            </div>
        </div>
        <!-- Top bar End -->

        <!-- Nav Bar Start -->
        <div class="nav">
            <div class="container-fluid">
                <nav class="navbar navbar-expand-md bg-dark navbar-dark">
                    <a href="#" class="navbar-brand">MENÜ</a>
                    <button type="button" class="navbar-toggler" data-toggle="collapse" data-target="#navbarCollapse">
                        <span class="navbar-toggler-icon"></span>
                    </button>

                    <div class="collapse navbar-collapse justify-content-between" id="navbarCollapse">
                        <div class="navbar-nav mr-auto">
                            <a href="AnaSayfa.aspx" class="nav-item nav-link active">Ana Sayfa</a>
                            <a href="Urunler.aspx" class="nav-item nav-link">Ürünler</a>
                        </div>
                        <div class="navbar-nav ml-auto">
                            <div class="nav-item dropdown">
                                <a href="#" class="nav-link dropdown-toggle" data-toggle="dropdown">Kullanıcı Hesabı</a>
                                <div class="dropdown-menu">
                                    <a href="Giris.aspx" class="dropdown-item">Giriş Yap</a>
                                    <a href="Kayit.aspx" class="dropdown-item">Üye Ol</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </nav>
            </div>
        </div>
        <!-- Nav Bar End --> 

        <!-- Bottom Bar Start -->
        <div class="bottom-bar">
            <div class="container-fluid">
                <div class="row align-items-center">
                    <div class="col-md-3">
                        <div class="logo">
                            <a href="index.html">
                                <img src="Dosyalar/img/logo.png" alt="Logo">
                            </a>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="search">
                            <input type="text" placeholder="Urun, kategori veya marka ara">
                            <button><i class="fa fa-search"></i></button>
                        </div>
                    </div>
                    <div class="col-md-3">
                        <div class="user">
                            <a href="wishlist.html" class="btn wishlist">
                                <i class="fa fa-heart"></i>
                                <span> Beğendiklerim (0)</span>
                            </a>
                            <a href="cart.html" class="btn cart">
                                <i class="fa fa-shopping-cart"></i>
                                <span> Sepetim (0)</span>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Bottom Bar End --> 

        <!-- Main Slider Start -->
        <div class="header">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-md-3">
                        <nav class="navbar bg-light">
                            <ul class="navbar-nav">
                                <li class="nav-item">
                                    <a class="nav-link" href="#"><i class="fa fa-microchip"></i>Ardunio</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" href="#"><i class="fas fa-car-battery"></i>Elektronik Kart</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" href="#"><i class="fas fa-cubes"></i>3D</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" href="#"><i class="fas fa-fan"></i>Motor</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" href="#"><i class="fas fa-bolt"></i>Sensör</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" href="#"><i class="fas fa-battery-full"></i>Güç Kaynağı - Batarya</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" href="#"><i class="fa fa-mobile-alt"></i>Proptipleme - Lehimleme</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" href="#"><i class="fas fa-tools"></i>Araç-Gereç</a>
                                </li>
                            </ul>
                        </nav>
                    </div>
                    <div class="col-md-6">
                        <div class="header-slider normal-slider">
                            <div class="header-slider-item">
                                <img src="Dosyalar/img/slider-1.png" alt="Slider Image" />
                            </div>
                            <div class="header-slider-item">
                                <img src="Dosyalar/img/slider-2.png" alt="Slider Image" />
                            </div>
                            <div class="header-slider-item">
                                <img src="Dosyalar/img/slider-3.png" alt="Slider Image" />
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3">
                        <div class="header-img">
                            <div class="img-item">
                                <img src="Dosyalar/img/category-1.png" class="auto-style1" />
                            </div>
                            <div class="img-item">
                                <img src="Dosyalar/img/category-2.png" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Main Slider End -->  

        <!-- Featured Product Start -->
        <div class="featured-product product">
            <div class="container-fluid">
                <div class="section-header">
                    <h1>Editörün Seçimi</h1>
                </div>
                <div class="row align-items-center product-slider product-slider-4">
                    <div class="col-lg-3">
                        <div class="product-item">
                            <div class="product-title">
                                <a href="#">mBot Bluetooth Kiti v1.1</a>
                                <div class="ratting">
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                </div>
                            </div>
                            <div class="product-image">
                                <a href="product-detail.html">
                                    <img src="Dosyalar/img/product-1.jpg" alt="Product Image">
                                </a>
                                <div class="product-action">
                                    <a href="#"><i class="fa fa-cart-plus"></i></a>
                                    <a href="#"><i class="fa fa-heart"></i></a>
                                </div>
                            </div>
                            <div class="product-price">
                                <h3><span>₺</span>554,81</h3>
                                <a class="btn" href=""><i class="fa fa-shopping-cart"></i>Satın Al</a>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3">
                        <div class="product-item">
                            <div class="product-title">
                                <a href="#">Arduino UNO R3 Klon USB Kablo Hediyeli</a>
                                <div class="ratting">
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                </div>
                            </div>
                            <div class="product-image">
                                <a href="product-detail.html">
                                    <img src="Dosyalar/img/product-2.jpg" alt="Product Image">
                                </a>
                                <div class="product-action">
                                    <a href="#"><i class="fa fa-cart-plus"></i></a>
                                    <a href="#"><i class="fa fa-heart"></i></a>
                                </div>
                            </div>
                            <div class="product-price">
                                <h3><span>₺</span>28,45</h3>
                                <a class="btn" href=""><i class="fa fa-shopping-cart"></i>Satın Al</a>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3">
                        <div class="product-item">
                            <div class="product-title">
                                <a href="#">Arduino Başlangıç Seti </a>
                                <div class="ratting">
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                </div>
                            </div>
                            <div class="product-image">
                                <a href="product-detail.html">
                                    <img src="Dosyalar/img/product-3.jpg" alt="Product Image">
                                </a>
                                <div class="product-action">
                                    <a href="#"><i class="fa fa-cart-plus"></i></a>
                                    <a href="#"><i class="fa fa-heart"></i></a>
                                </div>
                            </div>
                            <div class="product-price">
                                <h3><span>₺</span>83,68</h3>
                                <a class="btn" href=""><i class="fa fa-shopping-cart"></i>Satın Al</a>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3">
                        <div class="product-item">
                            <div class="product-title">
                                <a href="#">Creality Ender 3 V2 3D Yazıcı</a>
                                <div class="ratting">
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                </div>
                            </div>
                            <div class="product-image">
                                <a href="product-detail.html">
                                    <img src="Dosyalar/img/product-4.png" alt="Product Image">
                                </a>
                                <div class="product-action">
                                    <a href="#"><i class="fa fa-cart-plus"></i></a>
                                    <a href="#"><i class="fa fa-heart"></i></a>
                                </div>
                            </div>
                            <div class="product-price">
                                <h3><span>₺</span>2.400,00</h3>
                                <a class="btn" href=""><i class="fa fa-shopping-cart"></i>Satın Al</a>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3">
                        <div class="product-item">
                            <div class="product-title">
                                <a href="#">Arduino Motor Sürücü Shield</a>
                                <div class="ratting">
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                </div>
                            </div>
                            <div class="product-image">
                                <a href="product-detail.html">
                                    <img src="Dosyalar/img/product-5.jpg" alt="Product Image">
                                </a>
                                <div class="product-action">
                                    <a href="#"><i class="fa fa-cart-plus"></i></a>
                                    <a href="#"><i class="fa fa-heart"></i></a>
                                </div>
                            </div>
                            <div class="product-price">
                                <h3><span>₺</span>22,18</h3>
                                <a class="btn" href=""><i class="fa fa-shopping-cart"></i>Satın Al</a>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3">
                        <div class="product-item">
                            <div class="product-title">
                                <a href="#">L298N Voltaj Regulatörlü Çift Motor Sürücü Kartı</a>
                                <div class="ratting">
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                </div>
                            </div>
                            <div class="product-image">
                                <a href="product-detail.html">
                                    <img src="Dosyalar/img/product-ekstra1.jpg" alt="Product Image">
                                </a>
                                <div class="product-action">
                                    <a href="#"><i class="fa fa-cart-plus"></i></a>
                                    <a href="#"><i class="fa fa-heart"></i></a>
                                </div>
                            </div>
                            <div class="product-price">
                                <h3><span>₺</span>13,81</h3>
                                <a class="btn" href=""><i class="fa fa-shopping-cart"></i>Satın Al</a>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3">
                        <div class="product-item">
                            <div class="product-title">
                                <a href="#">ZD-10A Kalem Havya Standı</a>
                                <div class="ratting">
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                    <i class="fa fa-star"></i>
                                </div>
                            </div>
                            <div class="product-image">
                                <a href="product-detail.html">
                                    <img src="Dosyalar/img/product-ekstra2.jpg" alt="Product Image">
                                </a>
                                <div class="product-action">
                                    <a href="#"><i class="fa fa-cart-plus"></i></a>
                                    <a href="#"><i class="fa fa-heart"></i></a>
                                </div>
                            </div>
                            <div class="product-price">
                                <h3><span>₺</span>18,83</h3>
                                <a class="btn" href=""><i class="fa fa-shopping-cart"></i>Satın Al</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Featured Product End -->
     
        <!-- Footer Start -->
        <div class="footer">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-lg-3 col-md-6">
                        <div class="footer-widget">
                            <h2>İletişim</h2>
                            <div class="contact-info">
                                <p><i class="fa fa-map-marker"></i>Robotistan Elektronik Ticaret AŞ, Başakşehir, Türkiye</p>
                                <p><i class="fa fa-envelope"></i>robotistan@gmail.com</p>
                                <p><i class="fa fa-phone"></i>+0850 567 69 34</p>
                            </div>
                        </div>
                    </div>
                    
                    <div class="col-lg-3 col-md-6">
                        <div class="footer-widget">
                            <h2>Takip Edin</h2>
                            <div class="contact-info">
                                <div class="social">
                                    <a href=""><i class="fab fa-twitter"></i></a>
                                    <a href=""><i class="fab fa-facebook-f"></i></a>
                                    <a href=""><i class="fab fa-linkedin-in"></i></a>
                                    <a href=""><i class="fab fa-instagram"></i></a>
                                    <a href=""><i class="fab fa-youtube"></i></a>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="col-lg-3 col-md-6">
                        <div class="footer-widget">
                            <h2>Şirket Bilgileri</h2>
                            <ul>
                                <li><a href="#">Hakkımızda</a></li>
                                <li><a href="#">Gizlilik Politikası</a></li>
                                <li><a href="#">Şartlar ve Koşullar</a></li>
                            </ul>
                        </div>
                    </div>

                    <div class="col-lg-3 col-md-6">
                        <div class="footer-widget">
                            <h2>Satın Alma Bilgileri</h2>
                            <ul>
                                <li><a href="#">Ödeme Politikası</a></li>
                                <li><a href="#">Nakliye Politikası</a></li>
                                <li><a href="#">İade politikasi</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                
                <div class="row payment align-items-center">
                    <div class="col-md-6">
                        <div class="payment-method">
                            <h2>Ödeme Yöntemleri:</h2>
                            <img src="Dosyalar/img/payment-method.png" alt="Payment Method" />
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="payment-security">
                            <h2>Güvenlik:</h2>
                            <img src="Dosyalar/img/godaddy.svg" alt="Payment Security" />
                            <img src="Dosyalar/img/norton.svg" alt="Payment Security" />
                            <img src="Dosyalar/img/ssl.svg" alt="Payment Security" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Footer End -->

        <!-- Footer Bottom Start -->
        <div class="footer-bottom">
            <div class="container">
                <div class="row">
                    <div class="col-md-6 copyright">
                        <p>Copyright &copy; <a href="https://www.robotistan.com/">Robotistan Elektronik Ticaret AŞ</a> Tüm hakları saklıdır.</p>
                    </div>
                </div>
            </div>
        </div>
        <!-- Footer Bottom End --> 

        <!-- Back to Top -->
        <a href="#" class="back-to-top"><i class="fa fa-chevron-up"></i></a>
        
        <!-- JavaScript Libraries -->
        <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.bundle.min.js"></script>
        <script src="Dosyalar/lib/easing/easing.min.js"></script>
        <script src="Dosyalar/lib/slick/slick.min.js"></script>
        
        <!-- Template Javascript -->
        <script src="Dosyalar/js/main.js"></script>
    </body>
</html>
