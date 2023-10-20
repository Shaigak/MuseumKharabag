$(function () {





    $(document).on("click", ".clickfotos", function () {

        let menu = $(".dropmenufoto")


      


        if (menu.hasClass("d-none")) {

            menu.removeClass("d-none")
        } else {
            menu.addClass("d-none")
        }




      /*  $(menu).removeClass("d-none")*/

   
        //if (menu.hasClass("d-none"){
        //    menu.removeClass("d-none")
        //} else {
        //    menu.addClass("d-none")
        //}

       
     

    });



})