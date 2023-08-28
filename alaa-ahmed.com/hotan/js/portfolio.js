// ---------------------
// :: Portfolio Filtering
// ---------------------

$('#portfolio-grid').imagesLoaded(function () {
    // filter items on button click
    $('.list-control').on('click', 'li', function () {
        var filterValue = $(this).attr('data-filter');
        $grid.isotope({
            filter: filterValue
        });
    });
    // init Isotope
    var $grid = $('#portfolio-grid').isotope({
        itemSelector: '.item',
        percentPosition: true,
        isFitWidth: true,
        masonry: {
            // use outer width of grid-sizer for columnWidth
            columnWidth: '.item'
        }
    });
    $(window).resize(function () {
        $grid.isotope({
            columnWidth: '.col-sm-3'
        });
    });
    $grid.isotope({
        filter: '*'
    });
});

// ---------------------
// :: Portfolio Menu
// ---------------------

$('.list-control ul li').on('click', function (event) {
    $(this).siblings('.active').removeClass('active');
    $(this).addClass('active');
    event.preventDefault();
});

// ---------------------
// :: Portfolio Full Screen Picture
// ---------------------

// Initialize popup as usual
$('.zoom-gallery').magnificPopup({
    delegate: 'a',
    type: 'image',
    closeOnContentClick: false,
    closeBtnInside: false,
    mainClass: 'mfp-with-zoom mfp-img-mobile',
    image: {
        verticalFit: true,
    },
    gallery: {
        enabled: true
    },
    zoom: {
        enabled: true, // By default it's false, so don't forget to enable it

        duration: 300, // duration of the effect, in milliseconds
        easing: 'ease-in-out', // CSS transition easing function

        // The "opener" function should return the element from which popup will be zoomed in
        // and to which popup will be scaled down
        // By defailt it looks for an image tag:
        opener: function (openerElement) {
            // openerElement is the element on which popup was initialized, in this case its <a> tag
            // you don't need to add "opener" option if this code matches your needs, it's defailt one.
            return openerElement.is('img') ? openerElement : openerElement.find('img');
        }
    }

});