$(document).ready(function () {
    //注册提交按钮单击事件
    $("#BtnZC").click(function () {

        var txtUname = $("#uname").val(); //获取文本框的值
        var txtUPassword = $("#upassword").val();
        var txtUEmail = $("#ermail").val();
        var txtUBirthday = $("#ubirthday").val();
        var txtUsex = $("#usex").val();
        var txtUClass = $("#uclass").val();
        var txtUStatement = $("#ustatement").val();
        var txtURegDate = $("#uregdate").val();
        var txtUState = $("#ustate").val();
        var txtUPoint = $("#upoint").val();

        if (txtUsex == "女") {
            txtUsex = false;
        }
        else { txtUsex = true;}

        if ("" != txtUname && "" != txtUPassword && "" != txtUEmail && "" != txtUBirthday && "" != txtUsex && "" != txtUClass && "" != txtUStatement && "" != txtURegDate && "" != txtUState && "" != txtUPoint) {   //简单的验证放在客户端，减少服务器压力
            //利用post方式向服务器请求数据 
            $.ajax({
                type: "Post",
                url: "ashx/zhuce.ashx",
                    
                data: {
                    "Uname": txtUname, "UPassword": txtUPassword, "UEmail": txtUEmail, "UBirthday": txtUBirthday, "Usex": txtUsex,
                    "UClass": txtUClass, "UStatement": txtUStatement, "URegDate": txtURegDate, "UState": txtUState, "UPoint": txtUPoint
                },
                dataType: "text",
                success: function (data) {
                    //返回类型为text时 要处理一下 
                    var json = eval('(' + data + ')');
                    //   $("#result").val(json); 
                    alert(json.info + " 账号：" + json.Uname + "注册成功");
                    window.location.href = "login.html";//页面跳转
                },
                error: function (err) {
                    alert(123);
                }
            });
        }
        else {
            alert("输入非法！");

        }
    });

});