$(document).ready(function(){
	$(window).scroll(function() {    
    var scroll = $(window).scrollTop();    
    if (scroll >= 200) {
        $(".gotoTopo").css("display","block");
    }else{
    	$(".gotoTopo").css("display","none");
    }
});
});