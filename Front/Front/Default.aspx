<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Front.Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent"/>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
        <div class="header" id="home">
            <!--js-->   
            <script src="js/bootstrap.min.js"></script>
            <!--js-->
            <div class="banner">
                <div class="container">
                    <nav class="navbar navbar-default bg">
                        <!-- Brand and toggle get grouped for better mobile display -->
                          <div class="logo">
                              <a href="Default.aspx">North Wales<span> Crusaders</span></a>
                        </div>
                        <div class="navbar-header">
                          <button type="button" class="navbar-toggle collapsed mod" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar wt"></span>
                            <span class="icon-bar wt"></span>
                            <span class="icon-bar wt"></span>
                          </button>
                        </div>
                        <!-- Collect the nav links, forms, and other content for toggling -->
                        <div class="collapse navbar-collapse bod" id="bs-example-navbar-collapse-1"> 
                          <ul class="nav navbar-nav navbar-right navigate">
                            <li><a href="#about" class="scroll">ABOUT</a></li>
                            <li><a href="#services" class="scroll">SERVICES</a></li>
                           <li><a href="#contact" class="scroll">CONTACT</a></li>
                          </ul>
                        </div><!-- /.navbar-collapse -->
                          <div class="clearfix"></div>
                    </nav>
                <!--start-smoth-scrolling-->
                <script type="text/javascript" src="js/move-top.js"></script>
                <script type="text/javascript" src="js/easing.js"></script>
                <script type="text/javascript">
                    jQuery(document).ready(function ($) {
                        $(".scroll").click(function (event) {
                            event.preventDefault();
                            $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 1000);
                        });
                    });
                </script>
                <!--start-smoth-scrolling-->
            <div class="clear"></div>
            </div>
         </div>
            <div class="banner-slider">
                <script>
                    $(function () {
                      $("#slider").responsiveSlides({
                        auto: true,
                        nav: true,
                        speed: 500,
                        namespace: "callbacks",
                        pager: true,
                      });
                    });
                  </script>
                  </script>
                <div class="slider">
                    <div class="callbacks_container">
                      <ul class="rslides" id="slider">
                        <li>
                          <img src="images/1.jpg" alt="" class="img-responsive" />
                          <div class="caption chn">
                            <h3>купить билеты блаблабла</h3>
                            <p>Присоединяйтесь к нам! И вас вылечим!</p>
                            <a class="morebtn" href="#">Купить</a>
                          </div>
                        </li>
                        <li>
                          <img src="images/2.jpg" alt="" class="img-responsive" />
                            <div class="caption chn">
                             <h3>И тут чтото надо написать</h3>
                            <p>Следующий матч уже в это воскресение!</p>
                            <a class="morebtn" href="#">Купить</a>
                          </p>
                            </div>
                        </li>
                        <li>
                          <img src="images/3.jpg" alt="" class="img-responsive" />
                            <div class="caption chn">
                            <h3>Скорее быстрее покупаем билеты</h3>
                             <p>Самое время нажать "купить" </p>
                            <a class="morebtn" href="#">купить</a>
                            </div>
                        </li>
                      </ul>
                  </div>
                </div>
            </div>
        </div>
        <div class="about-deer" id="about">
            <div class="container">
                <div class="about-para">
                    <h1>About North Wales Crusaders</h1>
                    <p>The club was founded in 2011 following the folding of Crusaders Rugby League. They officially joined Championship 1, the third tier of rugby league in the United Kingdom, on 11 October 2011. Their name, which continues the Crusaders branding, was selected in a fan contest. A rival bid from Wrexham-based Glyndwr Chargers was withdrawn.
					The club held open trials for any new players to attend.</p>
                </div>
                <div class="about-grid">
                    <div class="col-md-4 grid lft">
                        <h4>Mission Statement</h4>
                        <p>Надо запилить из википедии </p>
                    </div>
                    <div class="col-md-4 grid cen">
                        <h4>Sport Solutions</h4>
                        <p>А это с офф сайта</p>
                    </div>
                    <div class="col-md-4 grid rgt">
                        <h4>Club History</h4>
                        <p>В жопу вашу историю</p>
                    </div>
                <div class="clear-fix"></div>
                </div>
            </div>
        </div>
        <div class="deer-sollution">
            <div class="container">
                <h2>Тут будет чтото хорошее, я уже забыла что я хотела</h2>
                <p>А сюда  запилю красивый текст</p>
                <a href="#">VIEW MORE</a>
            </div>
        </div>
        <div class="deer-services" id="services">
            <div class="container">
                <h3>Services</h3>
                <div class="statistics">
                    <div class="sap_tabs">	
                         <div id="horizontalTab" style="display: block; width: 100%; margin: 0px;">
                              <ul class="resp-tabs-list">
                                   <li class="resp-tab-item fs" aria-controls="tab_item-0" role="tab">                                             <span>SOUL</span></li>
                                    <li class="resp-tab-item fs" aria-controls="tab_item-1" role="tab">
                                    <span>TEAM-SPLITING</span></li>
                                     <li class="resp-tab-item fs" aria-controls="tab_item-2" role="tab">                                           <span>Stadiums</span></li>
                                  <div class="clearfix"></div>
                              </ul>				  	 
                                <div class="resp-tabs-container">
                                    <div class="tab-1 resp-tab-content msg" aria-labelledby="tab_item-0">
                                        <img src="images/a.jpg" alt="" class="img-responsive"/>
                                        <h4>SOUL</h4>
                                        <P>smth                            </P>
                                        <a href="#">HIRE US</a>
                                    </div>
                                    <div class="tab-1 resp-tab-content msg" aria-labelledby="tab_item-1">
                                        <img src="images/b.jpg" alt="" class="img-responsive"/>
                                        <h4>TEAM-SPLITING</h4>
                                        <p>smth tooo много много блаблабла                            </p>
                                        <a href="#">HIRE US</a>
                                    </div>
                                    <div class="tab-1 resp-tab-content msg" aria-labelledby="tab_item-2">
                                        <img src="images/c.jpg" alt="" class="img-responsive"/>
                                        <h4>Stadiums</h4>
                                        <p>The Racecourse Ground is located in Wrexham in North Wales and is the official home of the Crusaders and where most matches are played. The club moved to the ground in 2010, in time for the start of the Super League XV season. The first Crusaders match ever played there was against Leeds on 29 January 2010, and that match is also the highest attendance for a Crusaders match played in Wrexham. With a capacity of 15,500 it is the largest ground in North Wales, the fifth largest in the whole of Wales, and the seventh largest in Super League. It was first built in 1807 and first played host to Wrexham's "Town Purse" horse race.[4] Crowd trouble stopped the horse racing and in 1864 it became home to Wrexham Football Club with the club now owning the ground.[5][6][7] The Wales national rugby league team have played there. The ground has four stands: The Mold Road Stand, the Eric Roberts Stand, the Kop and the Yale.


During pre-season of the 2012 campaign. North Wales Crusaders played 'Home' games at both Halton Stadium[8] and Eirias Park.


Whilst resurfacing work was taking place at the Racecourse Ground in 2014, North Wales Crusaders took their home games to 'the Rock' in Rhosymedre, Wrexham.                             </p>
                                        <a href="#">HIRE US</a>
                                    </div>
                                </div>
                        </div>
                        <script src="js/easyResponsiveTabs.js" type="text/javascript"></script>
                            <script type="text/javascript">
                                $(document).ready(function () {
                                    $('#horizontalTab').easyResponsiveTabs({
                                        type: 'default', //Types: default, vertical, accordion           
                                        width: 'auto', //auto or any width like 600px
                                        fit: true   // 100% fit in a container
                                    });
                                });
                            </script>	
                    </div>
                </div>
            </div>
        </div>
           
                <script src="js/jquery.wmuSlider.js"></script> 
                  <script>
                      $('.example1').wmuSlider();         
                 </script> 	           	      
            </div>
          
                <a href="images/w.jpg" title="Tusken-City-Riders" rel="title1" class="img-responsive">
                    <img class="lazyOwl img-responsive" data-src="images/w.jpg" alt="name" />
                                </a>
                            </div>
                            
                        </div>
                    </div>
            </div>
        </div>

            <div class="foot-ban"> 
                <h3><q>Our team</q></h3>
            </div>
            <div class="contact" id="contact">
                <h3>Contact</h3>
                <p>Contact</p>
            </div>
            <!--footer-->
            <div class="footer" id="foot">
                <div class="container">
                    <div class="col-md-3 logo flt">
                        <a href="#">North Wales <span>Crusaders</span></a>
                    </div>
                    <div class="col-md-6 cpyrt fltt">
                        <p>Copyright 2015 - Olga Kosyura & Pavel Berezhnoy 
                         </div>
                    <div class="col-md-3 flt">
                        <div class="social">
                            <ul>
                                <li><a href="#" class="face"></a></li>
                                <li><a href="#" class="twit"></a></li>
                                <li><a href="#" class="in"></a></li>
                                <li><a href="#" class="gpls"></a></li>
                                <li><a href="#" class="del"></a></li>
                            </ul>
                        </div>
                    </div>
                    <div class="clear"></div>
                </div>
            </div>
            <!--footer-->
</asp:Content>