using System;
namespace YourFramework.Core.Events
{
    // Interface cho các class muốn đăng ký lắng nghe sự kiện
    public interface IEventSubscriber
    {
        // Phương thức xử lý sự kiện với dữ liệu sự kiện được truyền vào
        void HandleEvent<TEvent>(TEvent eventData);
    }
}
