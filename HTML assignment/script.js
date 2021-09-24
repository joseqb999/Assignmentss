$(document).ready(() => {
    // Adding shadow after scroll
    $(window).scroll(() => {
        if (this.scrollY > 20) {
            $('.nav-bar').addClass("sticky");
        } else {
            $('.nav-bar').removeClass("sticky");
        }
    });

    // Toggle menu
    $('.menu-button').click(() => {
        $('.nav-bar .menu').toggleClass("active");
        $('.menu-button').toggleClass("active");
    });

    $('.nav-bar .menu .menu-close-button').click(() => {
        $('.nav-bar .menu').toggleClass("active");
        $('.menu-button').toggleClass("active");
    });

    // Closing navigation menu on link click
    $('.nav-bar .menu li a').click(() => {
        $('.nav-bar .menu').toggleClass("active");
        $('.menu-button').toggleClass("active");
    });

    // Gallery hover
    $('.work .gallery .gallery-item .img-text-wrapper').hover(function () {
        $($(this).parent()[0].childNodes[1]).toggleClass('img-draken');
    });
    
});