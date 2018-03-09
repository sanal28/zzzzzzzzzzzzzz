
function Validate(type)
{
    var returnVal = true;
    var filter = /^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/;
    if (type == 'emp')
    {
        if ($("#txtNewEmployee").val() == '') {
            $("#divNewEmployee").addClass("ErrorFocus");
            returnVal = false;
        }
        else
            $("#divNewEmployee").removeClass("ErrorFocus");

        if ($("#txtPassword").val() == '') {
            $("#divPassword").addClass("ErrorFocus");
            returnVal = false;
        }
        else {
            $("#divPassword").removeClass("ErrorFocus");
        }

        if ($("#txtReTypePassword").val() == '') {
            $("#divReTypePassword").addClass("ErrorFocus");
            returnVal = false;
        }
        else {
            $("#divReTypePassword").removeClass("ErrorFocus");
        }

        if ($("#txtReTypePassword").val() != '') {

            if ($("#txtPassword").val() != $("#txtReTypePassword").val()) {
                $("#divPassword").addClass("ErrorFocus");
                $("#divReTypePassword").addClass("ErrorFocus");
                $('#pValidateMsg').text("*password doesn't match");
                returnVal = false;
            }
            else {
                $("#divPassword").removeClass("ErrorFocus");
                $("#divReTypePassword").removeClass("ErrorFocus");
            }
        }



        if ($("#txtEmailId").val() == '') {
            $("#divEmailId").addClass("ErrorFocus");
            returnVal = false;
        }
        else {
            $("#divEmailId").removeClass("ErrorFocus");
        }
        
        if($("#txtEmailId").val() != '')
        {
            if (!filter.test($("#txtEmailId").val())) {
                $("#divEmailId").addClass("ErrorFocus");
                $('#pValidateMsg').text("*invalid email id");
                returnVal = false;

            }
            else {
                $("#divEmailId").removeClass("ErrorFocus");
            }
        }

    }

    else if (type == 'support')
    {
        if ($("#txtuserName").val() == '')
        {
            $("#divUserName").addClass("ErrorFocus");
            returnVal = false;
        }
        else
        { $("#divUserName").removeClass("ErrorFocus"); }
        if ($("#txtsupportArea").val() == '') {
            $("#divTxtArea").addClass("ErrorFocus");
            returnVal = false;
        } else {
            $("#divTxtArea").removeClass("ErrorFocus");
        } if ($("#txtEmail").val() == '') {
            $("#divEmailId").addClass("ErrorFocus");
            returnVal = false;
        } else {
            $("#divEmailId").removeClass("ErrorFocus");
            var check = filter.test($("#txtEmail").val());
            if (!filter.test($("#txtEmail").val()))
            {
                $("#divEmailId").addClass("ErrorFocus");
                $('#lblerror').text("Please enter valid email");
                returnVal = false;
            } else
            {
                $("#divEmailId").removeClass("ErrorFocus");
            }
        }
    }

    return returnVal;
}