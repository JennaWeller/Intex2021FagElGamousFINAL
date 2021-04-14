// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.



// Write your JavaScript code.
$("select").on("click", function () {



    $(this).parent(".select-box").toggleClass("open");



});



$(document).mouseup(function (e) {
    var container = $(".select-box");



    if (container.has(e.target).length === 0) {
        container.removeClass("open");
    }
});




$("select").on("change", function () {



    var selection = $(this).find("option:selected").text(),
        labelFor = $(this).attr("id"),
        label = $("[for='" + labelFor + "']");



    label.find(".label-desc").html(selection);



});



var btnUpload = $("#upload_file"),
    btnOuter = $(".button_outer");
btnUpload.on("change", function (e) {
    var ext = btnUpload.val().split('.').pop().toLowerCase();
    if ($.inArray(ext, ['gif', 'png', 'jpg', 'jpeg']) == -1) {
        $(".error_msg").text("Not an Image...");
    } else {
        $(".error_msg").text("");
        btnOuter.addClass("file_uploading");
        setTimeout(function () {
            btnOuter.addClass("file_uploaded");
        }, 3000);
        var uploadedFile = URL.createObjectURL(e.target.files[0]);
        setTimeout(function () {
            $("#uploaded_view").append('<img src="' + uploadedFile + '" />').addClass("show");
        }, 3500);
    }
});
$(".file_remove").on("click", function (e) {
    $("#uploaded_view").removeClass("show");
    $("#uploaded_view").find("img").remove();
    btnOuter.removeClass("file_uploading");
    btnOuter.removeClass("file_uploaded");
});



document.addEventListener('DOMContentLoaded', function () {
    var radioButtons = document.getElementsByName('items');
    var fill = document.getElementById('fill');
    var hasSelection = false;
    var prevRect, checkedButton;



    function updateOffsets() {
        if (checkedButton) {
            var rect = checkedButton.nextElementSibling.getBoundingClientRect();
            fill.style.transition = 'none';
            fill.style.top = (rect.top + 5 + document.body.scrollTop) + 'px';
            fill.style.left = (rect.left + 5 + document.body.scrollLeft) + 'px';
            prevRect = rect;
        }
    }



    window.addEventListener('resize', updateOffsets);
    window.addEventListener('scroll', updateOffsets);



    document.addEventListener('change', function (e) {
        if (e.target.name === 'items') {




            Array.from(radioButtons).forEach(function (radioButton) {
                if (radioButton.checked) {
                    checkedButton = radioButton;
                    radioButton.parentNode.className = 'selected';
                    var rect = radioButton.nextElementSibling.getBoundingClientRect();



                    if (!hasSelection) {
                        fill.style.transition = 'none';
                        fill.style.top = (rect.top + 5 + document.body.scrollTop) + 'px';
                        fill.style.left = (rect.left + 5 + document.body.scrollLeft) + 'px';



                        fill.style.transform = 'scale(.2)';



                        setTimeout(function () {
                            fill.style.transition = '';
                            fill.style.opacity = 1;
                            fill.style.transform = 'scale(1)';
                        }, 25);
                    } else {
                        fill.style.transition = 'none';
                        fill.style.top = (rect.top + 5 + document.body.scrollTop) + 'px';
                        fill.style.left = (rect.left + 5 + document.body.scrollLeft) + 'px';
                        fill.style.transform = 'scale(1) translateY(' + (0 - (rect.top - prevRect.top - 5)) + 'px)';



                        setTimeout(function () {
                            fill.style.transition = '';
                            fill.style.opacity = 1;
                            fill.style.transform = 'scale(1) translateY(0px) translateX(0px)';
                        }, 25);



                    }



                    hasSelection = true;
                    prevRect = rect;
                } else {
                    radioButton.parentNode.className = '';
                }
            });



            return;
        }
    });
});