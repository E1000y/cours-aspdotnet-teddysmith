using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DTOs.Comment;
using api.Models;

namespace api.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto ToCommentDto(this Comment commentModel){
            return new CommentDto{
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreatedOn = commentModel.CreatedOn,
                StockId = commentModel.StockId
            };
        }
    


        public static Comment ToCommentFromCreate(this CreateCommentDto createCommentDto, int stockId ){
            return new Comment{
                Title = createCommentDto.Title,
                Content = createCommentDto.Content,
                StockId = stockId
            };
        }
         public static Comment ToCommentFromUpdate(this UpdateCommentRequestDto UpdateCommentRequestDto){
            return new Comment{
                Title = UpdateCommentRequestDto.Title,
                Content = UpdateCommentRequestDto.Content
            };
        }
    }
}