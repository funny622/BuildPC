//$('#btnlogin').click(function () {
//    var username = $('#username').val();
//    var password = $('#password').val();

//    alert(username);

//    $.ajax({
//        type: 'GET',
//        url: 'http://localhost:50895/api/user/login',
//        dataType: 'json',
//        headers: {
//            'Authorization': 'Basic' + username + ':' + password
//        },
//        success: function (data) {
//            $.each(data, function (key, val) {
//                var rows = '<p>Quyen truy cap cua ban la:' + val.PhanQuyen + '</p>';
//                $('result').html(rows);
//            });
//        },
//    });


//});

function Test()
{
    var username = document.getElementById('username').value;
    var password = $('#password').val();

    $.ajax
        ({
            type: "GET",
            url: "http://localhost:50895/api/user/login",
            dataType: 'json',
            async: false,
            headers: {
                "Authorization": "Basic " + btoa(username + ":" + password)
            },

            success: function (data)
            {
                alert(data.PhanQuyen);
            },
            complete: function (jqXHR)
            {
                if (jqXHR.status === '401')
                    alert("Bạn nhập sai tên đăng nhập hoặc mật khẩu.");
            },
        });
}


