using System;
using System.Collections.Generic;

namespace NFramework.Core.Events
{
    public class EventManager
    {
        // Từ điển để lưu trữ các sự kiện và các handler tương ứng
        private readonly Dictionary<Type, List<Action<object>>> _eventHandlers = new();

        // Đăng ký một handler cho sự kiện cụ thể
        public void Subscribe<TEvent>(Action<TEvent> handler)
        {
            var eventType = typeof(TEvent);

            // Nếu sự kiện chưa được đăng ký trước đó, thêm nó vào từ điển
            if (!_eventHandlers.ContainsKey(eventType))
            {
                _eventHandlers[eventType] = new List<Action<object>>();
            }

            // Thêm handler vào danh sách các handler của sự kiện
            _eventHandlers[eventType].Add(e => handler((TEvent)e));
        }

        // Phát đi một sự kiện để tất cả các handler lắng nghe và xử lý
        public void Publish<TEvent>(TEvent eventData)
        {
            var eventType = typeof(TEvent);

            // Kiểm tra nếu có bất kỳ handler nào được đăng ký cho sự kiện này
            if (_eventHandlers.ContainsKey(eventType))
            {
                // Gọi tất cả các handler đã đăng ký cho sự kiện này
                foreach (var handler in _eventHandlers[eventType])
                {
                    handler(eventData);
                }
            }
        }

        // Hủy đăng ký một handler cho sự kiện cụ thể
        public void Unsubscribe<TEvent>(Action<TEvent> handler)
        {
            var eventType = typeof(TEvent);

            if (_eventHandlers.ContainsKey(eventType))
            {
                _eventHandlers[eventType].Remove(e => handler((TEvent)e));
            }
        }
    }
}
