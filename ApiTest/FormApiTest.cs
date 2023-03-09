using ApiTest.Api;
using ApiTest.Model;
using ApiTest.Service;
using System;
using System.Windows.Forms;

namespace ApiTest
{
    public partial class FormApiTest : Form
    {
        public FormApiTest()
        {
            InitializeComponent();
        }

        private void FormApiTest_Load(object sender, EventArgs e)
        {

        }

        private void BtnApiResponse_Click(object sender, EventArgs e)
        {
            PostModel postModel = new ApiBasePost(ApiUrl.UrlPostPath + "99").Get();
            lblApiResponse.Text =  postModel.title;

            System.Collections.Generic.List<PostModel> postModels = new ApiBasePost(ApiUrl.UrlPostPath).GetList();
            lblApiListResponse.Text = postModels[0].body;
        }

        private void lblApiResponseClick(object sender, EventArgs e)
        {

        }

        private void lblApiListResponseClick(object sender, EventArgs e)
        {

        }
    }
}
