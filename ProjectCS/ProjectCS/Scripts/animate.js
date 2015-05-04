(function(){

    var init = function () {
        $('a').on(onmousedown, animateTest);
    }();

    function animateTest() {
       $(this).addClass('animated bounceOutLeft');
    }

    window.onload = init;
})();