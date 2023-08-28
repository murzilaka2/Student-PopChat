// Navbar Smoothscroll js
$('.single-job .apply-bttn .bttn.btn-purple').bind('click', function (event) {
    var $anchor = $(this);
    $('html, body').stop().animate({
        scrollTop: $($anchor.attr('href')).offset().top - 90
    }, 1000);
    event.preventDefault();
});

var Sticky = new hcSticky('aside', {
    stickTo: '.side-description-form',
    top: 90,
    responsive: {
        991: {
            disable: true
        }
    }
});