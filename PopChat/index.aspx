<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PopChat.index" %>
<%@ Register TagPrefix="Footer" TagName="Place" Src="~/Parts/Footer.ascx" %>
<%@ Register TagPrefix="Header" TagName="Place" Src="~/Parts/Header.ascx" %>
<%@ Register TagPrefix="NavBar" TagName="Place" Src="~/Parts/NavBar.ascx" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>POP Chat</title>    
    <meta name="description" content="" />
    <Header:Place  runat="server"/>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Start Header -->
        <NavBar:Place runat="server"/>
        <!-- End Header -->    
        <!-- Start Header Content -->
            <div class="head-content">
                <div class="container">
                    <div class="row row-aligns">
                        <div class="col-md-6 order-2 order-md-1">
                            <div class="head-txt">
                                <h2 class="h1">It's time to amplify your <span class="co-purple">online business</span></h2>
                                <p>
                                    With Hotan you get components and examples, including tons of variables that will help
                                you customize this theme with ease.
                                </p>
                                <div class="head-buttons">
                                    <a class="bttn btn-purple" href="#">Get Started
                                    <i class='bx bx-right-arrow-alt'></i>
                                    </a>
                                    <a class="bttn btn-empty" href="https://www.youtube.com/watch?v=afj3WB44lko"
                                        data-lity>Watch Video <i class='bx bx-right-arrow'></i></a>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6 order-1 order-md-2">
                            <div class="head-img">
                                <img class="img-fluid" src="img/chicago.svg" alt="Hotan Template">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- End Header Content -->
            <!-- Background Shape-->
            <div class="background-shapes">
                <div class="box1"></div>
                <div class="box2"></div>
                <div class="box3"></div>
                <div class="dot1"></div>
                <div class="dot2"></div>
                <div class="heart1"><i class='bx bx-message-square'></i></div>
                <div class="heart2"><i class='bx bx-heart'></i></div>
                <div class="circle2"></div>
            </div>
        <!-- Start Try Our Trial -->
        <section id="trial" class="trial">
            <div class="container">
                <h4>Get the brand new</h4>
                <p>
                    With Hotan you get components and examples, including tons of variables that will help you customize this
                theme with ease.
                </p>
                <div class="line-sepa"></div>
                <h3><span>1,693,752</span> User have been using our Services successfully.</h3>
                <img class="img-fluid" src="img/undraw_landscape_mode_53ej.svg" alt="Hotan Template">
            </div>
        </section>
        <!-- End Try Our Trial -->
        <!-- Start Working -->
        <section id="start-working" class="start-working">
            <div class="overlay"></div>
            <div class="container">
                <div class="row row-aligns">
                    <div class="col-lg-7">
                        <div class="video-place">
                            <a href="https://www.youtube.com/watch?v=afj3WB44lko" data-lity>
                                <i class='bx bx-right-arrow'></i>
                            </a>
                            <img class="img-fluid" src="img/people-coffee-meeting-team-7096.jpg" alt="Hotan Template">
                        </div>
                    </div>
                    <div class="col-lg-5">
                        <div class="video-txt">
                            <span>Why Us?</span>
                            <h3>Beautiful Place for your Great Journey</h3>
                            <p>
                                We tried to make very high-quality product and so our code is very neat and clean. Whatever
                            anyone could improve and modify the template to your liking.
                            </p>
                            <ul class="list-unstyled">
                                <div class="row">
                                    <div class="col-md-6">
                                        <li><i class='bx bx-bulb'></i>Modern Design</li>
                                        <li><i class='bx bx-vector'></i>Easy To Customize</li>
                                        <li class="active"><i class='bx bx-rocket'></i>Super Fast Load</li>
                                    </div>
                                    <div class="col-md-6">
                                        <li><i class='bx bx-check-double'></i>Clean & Valid Code</li>
                                        <li><i class='bx bx-collection'></i>Multipurpose Layout</li>
                                        <li><i class='bx bx-support'></i>24/7 Support</li>
                                    </div>
                                </div>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- End Working -->

        <!-- Start Blog -->
        <section id="blog" class="blog">
            <div class="container">
                <div class="main-title">
                    <h3>Recent News</h3>
                    <p>
                        Here's some thoughts
                        <br>
                        from our blog
                    </p>
                </div>
                <div class="row">
                    <!-- Start Post Item -->
                    <div class="col-md-6">
                        <div class="post-item">
                            <div class="post-txt">
                                <a class="post-title" href="#">Beautiful Place for your Great Journey</a>
                                <ul class="list-unstyled post-details">
                                    <li>John Doe</li>
                                    <li>9 Sep, 2020</li>
                                    <li>326 Comments</li>
                                </ul>
                                <p>
                                    Lorem, ipsum dolor sit amet consectetur adipisicing elit. Tenetur quam facere accusamus
                                dolore eos rerum ducimus eveniet vero at laborum quod quasi est odit nobis minima, earum
                                laudantium, ad quia.
                                </p>
                                <div class="footer-post">
                                    <div class="tags">
                                        <a href="#">Mobile</a>
                                    </div>
                                    <div class="action-post">
                                        <a href="#"><i class='bx bx-bookmark'></i></a>
                                        <a href="#"><i class='bx bx-heart'></i></a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- End Post Item -->
                    <!-- Start Post Item -->
                    <div class="col-md-6">
                        <div class="post-item mb-mob-0">
                            <div class="post-txt">
                                <a class="post-title" href="#">Beautiful Place for your Great Journey</a>
                                <ul class="list-unstyled post-details">
                                    <li>John Doe</li>
                                    <li>9 Sep, 2020</li>
                                    <li>326 Comments</li>
                                </ul>
                                <p>
                                    Lorem, ipsum dolor sit amet consectetur adipisicing elit. Tenetur quam facere accusamus
                                dolore eos rerum ducimus eveniet vero at laborum quod quasi est odit nobis minima, earum
                                laudantium, ad quia.
                                </p>
                                <div class="footer-post">
                                    <div class="tags">
                                        <a href="#">Development</a>
                                    </div>
                                    <div class="action-post">
                                        <a href="#"><i class='bx bx-bookmark'></i></a>
                                        <a href="#"><i class='bx bx-heart'></i></a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- End Post Item -->
                </div>
            </div>
        </section>
        <!-- End Blog -->
        <!-- Start Download App -->
        <section id="download" class="download parallax">
            <div class="overlay"></div>
            <div class="container">
                <div class="row">
                    <div class="col-lg-8">
                        <div class="txt-phone">
                            <i class='bx bx-cloud-download'></i>
                            <h3>Download our app</h3>
                            <p>
                                We tried to make very high-quality product and so our code is very neat and clean. Whatever
                            anyone could improve and modify the template to your liking.
                            </p>
                            <div class="download-bttn">
                                <a href="#" class="play-store">
                                    <i class='bx bxl-play-store'></i>
                                    <div class="txt-btn">
                                        <span>Get it on</span>
                                        <span>Play Store</span>
                                    </div>
                                </a>
                                <a href="#" class="apple-store">
                                    <i class='bx bxl-apple'></i>
                                    <div class="txt-btn">
                                        <span>Get it on</span>
                                        <span>Apple Store</span>
                                    </div>
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="img-phone">
                            <img class="img-fluid" src="img/mobile-phone.png" alt="Hotan Template">
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- End Download App -->

        <!-- Start Contact Us -->
        <section id="contact-us" class="contact-us">
            <div class="map-area" id="contacts">
                <div id="googleMap" style="width: 100%;"></div>
            </div>
            <div class="form-area">
                <div class="form-inner">
                    <!-- Background Shape-->
                    <div class="background-shapes">
                        <div class="box1"></div>
                        <div class="box2"></div>
                        <div class="box3"></div>
                        <div class="dot1"></div>
                        <div class="dot2"></div>
                        <div class="heart1"><i class='bx bx-message-square'></i></div>
                        <div class="heart2"><i class='bx bx-heart'></i></div>
                        <div class="circle2"></div>
                    </div>
                    <div class="container">
                        <div class="form-box">
                            <div class="main-title">
                                <h3>Get In Touch</h3>
                                <p>
                                    Please feel free to contact us
                                    <br>
                                    if you need any further information
                                </p>
                            </div>
                                <div class="row">
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <div class="floating-label-wrap">
                                                <input type="text" class="floating-label-field floating-label-field--s3"
                                                    id="field-1" placeholder="Full Name">
                                                <label for="field-1" class="floating-label">Имя</label>
                                            </div>
                                            <!-- .floating-label-wrap -->
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <div class="floating-label-wrap">
                                                <input type="email" class="floating-label-field floating-label-field--s3"
                                                    id="field-2" placeholder="E-Mail Address">
                                                <label for="field-2" class="floating-label">E-Mail</label>
                                            </div>
                                            <!-- .floating-label-wrap -->
                                        </div>
                                    </div>
                                    </div>
                                    <div class="col-xl-12">
                                        <div class="form-group">
                                            <div class="floating-label-wrap">
                                                <textarea class="floating-label-field floating-label-field--s3" id="field-5"
                                                    placeholder="Your Message"></textarea>
                                                <label for="field-5" class="floating-label">Сообщение</label>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-xl-12">
                                        <div class="form-buttons">
                                            <input type="submit" value="Отправить">
                                        </div>
                                    </div>
                                </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- End Contact Us -->
        <!-- Footer -->
        <Footer:Place runat="server"/>
    </form>
</body>
</html>
