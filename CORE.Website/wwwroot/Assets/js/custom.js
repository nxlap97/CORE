jQuery(document).ready(function($) {
	if($('.loading-content').length){
		setTimeout(function(){
			$('body').addClass('loaded');
		}, 3000);
	}

	if($('.mycarousel').length){
		$(".mycarousel").each(function(e){	
			$(this).jcarousel({
					vertical: true,
					center: true,
			        wrap: 'circular'
			    })
		})
	}

	if($('.btowl-demo').length){
		$('.btowl-demo').each(function(e){	
			$(this).owlCarousel({
				slideSpeed : 300,
				paginationSpeed : 400,
				singleItem : true
		    });
		})
	}

	if($('.btowl-shop').length){
		$('.btowl-shop').each(function(e){	
			$(this).owlCarousel({				
				items : 4,
				lazyLoad : true,
				pagination : false,
				navigation : true,
				navigationText : ['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>']
		    });
		})
	}

	if($('#pie-charts').length){
		$('#pie-charts').waypoint(function(direction) {			
			$('.chart').easyPieChart({
				 barColor: "#5ecae6",
				onStep: function(from, to, percent) {
					$(this.el).find('.percent').text(Math.round(percent));
				}
			});
			}, {
			offset: function() {
				return $.waypoints('viewportHeight') - $(this).height() + 100;
			}
		});
	}
	$("a[data-rel^='prettyPhoto']").prettyPhoto({
		default_width: 700,
		default_height: 544
	});
	$("a[rel^='prettyPhoto']").prettyPhoto({
	});

	$(window).scroll(function(){
		if($(window).scrollTop() > 200){
			$("#back-to-top").fadeIn(200);
		} else{
			$("#back-to-top").fadeOut(200);
		}
	});
	
	$('#back-to-top, .back-to-top').click(function() {
		  $('html, body').animate({ scrollTop:0 }, '800');
		  return false;
	});	

	//Maps
	$(".map-title h4 span").click(function(e) {
		$(".map #map_canvas").slideToggle();
		$(".map-title h4 span i").toggleClass("fa-angle-up fa-angle-down");
	});

	//CART
	var menu_timeout;
    $('.btcartitem').hover(
    	function(){
        var me=$(this);
             menu_timeout=window.setTimeout(function(){
                $(".btvmcart").slideDown();
             },300);
         },
        function(){
            var me=$(this);
            window.clearTimeout(menu_timeout);
            $(".btvmcart").slideUp();  
        }
    );

	$(".navbar-nav.scroll li a.scrollmenu").click(function(event){
		event.preventDefault();
		if(!$(this).hasClass('noscrollmenu')){
			if($(this.hash).length){
				 //calculate destination place
				 var dest=0;
				 if($(this.hash).offset().top > $(document).height()-$(window).height()){
					  dest=$(document).height()-$(window).height();
				 }else{
					  dest=$(this.hash).offset().top;
				 }
				 if($(this.hash).hasClass('services-sec'))
				 	dest = dest - 65;
				 //go to destination
				 jQuery('html,body').animate({scrollTop:dest}, 1000,'swing');
			}
			else{
				var address = $('body').data("url");
				window.open(address+(this.hash),'_self');
			}
		}
		else{
			var href = $(this).attr( "href" );
			window.open(href,'_self');
		}
	});

	/* ==========================================================================
	 Hover Submenu
	 ========================================================================== */	
    var menu_timeout;
    $('li.dropdown').hover(
    	function(){
        var me=$(this);
             menu_timeout=window.setTimeout(function(){
                 me.children('ul').slideDown();
             },300);
         },
        function(){
            var me=$(this);
            window.clearTimeout(menu_timeout);
            me.children('ul').slideUp();    
        }
    );
	

	var $allVideos = $(".box-section.video iframe, .box-section.video object, .box-section.video embed"),
		jQueryfluidEl = $(".box-section.video");
					
	$allVideos.each(function() {	
	  $(this)
		.attr('data-aspectRatio', this.height / this.width)
		.removeAttr('height')
		.removeAttr('width');	
	});
			
	$(window).resize(function() {
	
		var newWidth = jQueryfluidEl.width();
		$allVideos.each(function() {
			var jQueryel = $(this);
			jQueryel
			.width(newWidth)
			.height(newWidth * jQueryel.attr('data-aspectRatio'));
		});
		$(".box-section.video .bt-video").each(function() {
			var jQueryvideo = $(this);
			jQueryvideo
			.width(newWidth)
			.height(newWidth * jQueryvideo.attr('data-aspectRatio'));
		});


	}).resize();

});












		jQuery(function() {
			//tabs
			jQuery('.service-tab').click(function(e) {
				e.preventDefault();
				var target = jQuery(this).data('target');
				console.log(target);
				jQuery(".bt-tabs-btn").each(function(e){
					if(jQuery(this).hasClass(target)){
						jQuery(this).fadeIn(500);
						var item_tabs = jQuery(this).find('span i');
						item_tabs.addClass('open');
					}
					else{
						var item_tabs = jQuery(this).find('span i');
						item_tabs.removeClass('open');
						jQuery(this).fadeOut(500);
					}
				});
			});
			
			
			//add active class
			jQuery('.tabs-btn li a').click(function(e) {
				jQuery('.tabs-btn li a').removeClass('active');
				jQuery(this).addClass('active');
			});
			
			
			
			//top bar colors
			jQuery('.top-bar-colors li a#orange').click(function(e) {
				jQuery('.header-top').removeClass('green red blue purple');
				jQuery('.header-top').addClass('orange');
			});
			jQuery('.top-bar-colors li a#red').click(function(e) {
				jQuery('.header-top').removeClass('green orange blue purple');
				jQuery('.header-top').addClass('red');
			});
			jQuery('.top-bar-colors li a#green').click(function(e) {
				jQuery('.header-top').removeClass('orange red blue purple');
				jQuery('.header-top').addClass('green');
			});
			jQuery('.top-bar-colors li a#blue').click(function(e) {
				jQuery('.header-top').removeClass('green red orange purple');
				jQuery('.header-top').addClass('blue');
			});
			jQuery('.top-bar-colors li a#purple').click(function(e) {
				jQuery('.header-top').removeClass('green red blue orange');
				jQuery('.header-top').addClass('purple');
			});
			jQuery('.top-bar-colors li a#gray').click(function(e) {
				jQuery('.header-top').removeClass('green red blue orange purple');
			});
			
			//add active class in top bar
			jQuery('.top-bar-colors li a, .footer-colors li a').click(function(e) {
				jQuery('.top-bar-colors li a, .footer-colors li a').removeClass('active');
				jQuery(this).addClass('active');
			});
			
			
			//footer colors
			jQuery('.footer-colors li a#orange2').click(function(e) {
				jQuery('.footer-large').removeClass('green red blue purple');
				jQuery('.footer-large').addClass('orange');
			});
			jQuery('.footer-colors li a#red2').click(function(e) {
				jQuery('.footer-large').removeClass('green orange blue purple');
				jQuery('.footer-large').addClass('red');
			});
			jQuery('.footer-colors li a#green2').click(function(e) {
				jQuery('.footer-large').removeClass('orange red blue purple');
				jQuery('.footer-large').addClass('green');
			});
			jQuery('.footer-colors li a#blue2').click(function(e) {
				jQuery('.footer-large').removeClass('green red orange purple');
				jQuery('.footer-large').addClass('blue');
			});
			jQuery('.footer-colors li a#purple2').click(function(e) {
				jQuery('.footer-large').removeClass('green red blue orange');
				jQuery('.footer-large').addClass('purple');
			});
			jQuery('.footer-colors li a#gray2').click(function(e) {
				jQuery('.footer-large').removeClass('green red blue orange purple');
			});
			
			
			//add active class in footer
			jQuery('.footer-colors li a').click(function(e) {
				jQuery('.footer-colors li a').removeClass('active');
				jQuery(this).addClass('active');
			});
			

			//Animation
			jQuery('.btanimation').appear();
			jQuery(document.body).on('appear', '.btanimation', function(e, $affected) {
				var fadeDelayAttr;
				var fadeDelay;
				jQuery(this).each(function(){
				
	
					if (jQuery(this).data("delay")) {
						fadeDelayAttr = jQuery(this).data("delay")
						fadeDelay = fadeDelayAttr;				
					} else {
						fadeDelay = 0;
					}			
					jQuery(this).delay(fadeDelay).queue(function(){
						jQuery(this).addClass('animated').clearQueue();
					});			
				})			
			});

			//------------------------------------ EXPERIENCE -----------------------------------//
			
			jQuery('.experience .row .experience-content, .experience .row .devices, .table.table-price').appear();
			jQuery(document.body).on('appear', '.experience .row .experience-content, .experience .row .devices, .table.table-price', function(e, $affected) {
				var fadeDelayAttr;
				var fadeDelay;
				jQuery(this).each(function(){
				
	
					if (jQuery(this).data("delay")) {
						fadeDelayAttr = jQuery(this).data("delay")
						fadeDelay = fadeDelayAttr;				
					} else {
						fadeDelay = 0;
					}			
					jQuery(this).delay(fadeDelay).queue(function(){
						jQuery(this).addClass('animated').clearQueue();
					});			
				})			
			});
			
			//------------------------------------ SERVICES -----------------------------------//
			
			jQuery('.services-sec .row').appear();
			jQuery(document.body).on('appear', '.services-sec .row', function(e, $affected) {
				var fadeDelayAttr;
				var fadeDelay;
				jQuery(this).children('*').each(function(){
				
	
					if (jQuery(this).data("delay")) {
						fadeDelayAttr = jQuery(this).data("delay")
						fadeDelay = fadeDelayAttr;				
					} else {
						fadeDelay = 0;
					}			
					jQuery(this).delay(fadeDelay).queue(function(){
						jQuery(this).addClass('animated').clearQueue();
					});			
				})			
			});
			
			
			//------------------------------------ TRI SECS -----------------------------------//
			
			jQuery('.tri-secs .col-md-6').appear();
			jQuery(document.body).on('appear', '.tri-secs .col-md-6', function(e, $affected) {
				var fadeDelayAttr;
				var fadeDelay;
				jQuery(this).each(function(){
				
	
					if (jQuery(this).data("delay")) {
						fadeDelayAttr = jQuery(this).data("delay")
						fadeDelay = fadeDelayAttr;				
					} else {
						fadeDelay = 0;
					}			
					jQuery(this).delay(fadeDelay).queue(function(){
						jQuery(this).addClass('animated').clearQueue();
					});			
				})			
			});
			
			
			//------------------------------------ TEAM -----------------------------------//
			
			jQuery('.team .row .col-md-4').appear();
			jQuery(document.body).on('appear', '.team .row .col-md-4', function(e, $affected) {
				var fadeDelayAttr;
				var fadeDelay;
				jQuery(this).each(function(){
				
	
					if (jQuery(this).data("delay")) {
						fadeDelayAttr = jQuery(this).data("delay")
						fadeDelay = fadeDelayAttr;				
					} else {
						fadeDelay = 0;
					}			
					jQuery(this).delay(fadeDelay).queue(function(){
						jQuery(this).addClass('animated').clearQueue();
					});			
				})			
			});
			
			//------------------------------------ TABLE -----------------------------------//
			
			jQuery('.tables .row .col-md-3').appear();
			jQuery(document.body).on('appear', '.tables .row .col-md-3', function(e, $affected) {
				var fadeDelayAttr;
				var fadeDelay;
				jQuery(this).each(function(){
				
	
					if (jQuery(this).data("delay")) {
						fadeDelayAttr = jQuery(this).data("delay")
						fadeDelay = fadeDelayAttr;				
					} else {
						fadeDelay = 0;
					}			
					jQuery(this).delay(fadeDelay).queue(function(){
						jQuery(this).addClass('animated').clearQueue();
					});			
				})			
			});
			
			
			//------------------------------------ PORTFOLIO -----------------------------------//
			
			jQuery('#portfolio-items-wrap').appear();
			jQuery(document.body).on('appear', '#portfolio-items-wrap', function(e, $affected) {
				var fadeDelayAttr;
				var fadeDelay;
				jQuery(this).each(function(){
				
	
					if (jQuery(this).data("delay")) {
						fadeDelayAttr = jQuery(this).data("delay")
						fadeDelay = fadeDelayAttr;				
					} else {
						fadeDelay = 0;
					}			
					jQuery(this).delay(fadeDelay).queue(function(){
						jQuery(this).addClass('animated').clearQueue();
					});			
				})			
			});
			
			//------------------------------------ SHOP -----------------------------------//
			
			jQuery('.products .product').appear();
			jQuery(document.body).on('appear', '.products .product', function(e, $affected) {
				var fadeDelayAttr;
				var fadeDelay;
				jQuery(this).each(function(){
				
	
					if (jQuery(this).data("delay")) {
						fadeDelayAttr = jQuery(this).data("delay")
						fadeDelay = fadeDelayAttr;				
					} else {
						fadeDelay = 0;
					}			
					jQuery(this).delay(fadeDelay).queue(function(){
						jQuery(this).addClass('animated').clearQueue();
					});			
				})			
			});
			
			//------------------------------------ OUR CLIENTS -----------------------------------//
			
			jQuery('.our-clients .flipInY').appear();
			jQuery(document.body).on('appear', '.our-clients .flipInY', function(e, $affected) {
				var fadeDelayAttr;
				var fadeDelay;
				jQuery(this).each(function(){
				
	
					if (jQuery(this).data("delay")) {
						fadeDelayAttr = jQuery(this).data("delay")
						fadeDelay = fadeDelayAttr;				
					} else {
						fadeDelay = 0;
					}			
					jQuery(this).delay(fadeDelay).queue(function(){
						jQuery(this).addClass('animated').clearQueue();
					});			
				})			
			});
			
			
			//------------------------------------ CONTACT US -----------------------------------//
			
			jQuery('.contact-us .form').appear();
			jQuery(document.body).on('appear', '.contact-us .form', function(e, $affected) {
				var fadeDelayAttr;
				var fadeDelay;
				jQuery(this).each(function(){
				
	
					if (jQuery(this).data("delay")) {
						fadeDelayAttr = jQuery(this).data("delay")
						fadeDelay = fadeDelayAttr;				
					} else {
						fadeDelay = 0;
					}			
					jQuery(this).delay(fadeDelay).queue(function(){
						jQuery(this).addClass('animated').clearQueue();
					});			
				})			
			});
			
			//------------------------------------ SOCIAL -----------------------------------//
			
			jQuery('.social li').appear();
			jQuery(document.body).on('appear', '.social li', function(e, $affected) {
				var fadeDelayAttr;
				var fadeDelay;
				jQuery(this).each(function(){
				
	
					if (jQuery(this).data("delay")) {
						fadeDelayAttr = jQuery(this).data("delay")
						fadeDelay = fadeDelayAttr;				
					} else {
						fadeDelay = 0;
					}			
					jQuery(this).delay(fadeDelay).queue(function(){
						jQuery(this).addClass('animated').clearQueue();
					});			
				})			
			});
			
			
			
			
			
			//------------------------------------ SWITCHER -----------------------------------//
			
			//jQuery('#dark').click(function(e) {
//				jQuery(this).toggleClass('active');
//				if($('#dark').hasClass('active'))
//					$('#dark-css').attr("href", "css/dark_theme.css"),
//					$('.parallax-main-banner').css("background-position", "0 0");
//				else
//					$('#dark-css').attr("href", "");
//				});
			
			
			
			
		})