using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _CommentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _CommentDal = commentDal;
        }

        public void TAdd(Comment entity)
        {
            _CommentDal.Insert(entity);
        }

        public void TDelete(Comment entity)
        {
            _CommentDal.Delete(entity);
        }

        public Comment TGetById(int id)
        {
            return _CommentDal.GetById(id);
        }

        public List<Comment> TGetList()
        {
            return _CommentDal.GetList();
        }

        public void TUpdate(Comment entity)
        {
             _CommentDal.Update(entity);
        }
        public List<Comment> TGetCommentByDestinationId(int id)
        {
            return _CommentDal.GetListByFilter(x => x.DestinationID == id);
        }

        public List<Comment> TGetCommentWithDestination()
        {
            return _CommentDal.GetCommentWithDestination();
        }
    }
}
