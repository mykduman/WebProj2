$(window).on("scroll",function () {
    if($(window).scrollTop()){
      $(".menu").addClass("sticky");
      for(i=1;i<7;i++){
        $(".menuLink:nth-child("+i+")").addClass("stickyLink");
      }
    }
  else{
    $(".menu").removeClass("sticky");
    for(i=1;i<7;i++){
      $(".menuLink:nth-child("+i+")").removeClass("stickyLink");
    }
  }

});