using Harmic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Harmic.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly HarmicContext _context;
        public BlogViewComponent(HarmicContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var blogs = await _context.TbBlogs
                        .Where(b => b.IsActive) // Lọc các bài viết đang hoạt động
                        .OrderByDescending(b => b.CreatedDate) // Sắp xếp theo ngày tạo giảm dần
                        .ToListAsync(); // Thực hiện truy vấn bất đồng bộ

            return View(blogs); // Trả về view với danh sách bài viết
        }
    }
}
