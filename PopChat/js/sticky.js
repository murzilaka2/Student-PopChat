// ---------------------
// :: Sticky Sidebar
// ---------------------

// Navbar Smoothscroll js
$('.faq-control li a').bind('click', function (event) {
    var $anchor = $(this);
    $('html, body').stop().animate({
        scrollTop: $($anchor.attr('href')).offset().top - 100
    }, 1000);
    event.preventDefault();
});

// Change Color Links Faq Control
$(".faq-control li").on('click', function () {
    $(".faq-control li.active").removeClass('active');
    $(this).addClass('active');
    var active_section = $(this).attr('href'); //get active section id
    $('html, body').animate({
        //and scroll to the section
        scrollTop: $(active_section).offset()
    }, 1000);
});

var Sticky = new hcSticky('aside', {
    stickTo: '.faq-question',
    top: 150,
    responsive: {
        991: {
            disable: true
        }
    }
});