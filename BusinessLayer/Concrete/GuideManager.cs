﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GuideManager : IGuideService
    {
        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void ChangeToFalseByGuide(int id)
        {
            _guideDal.ChangeToFalse(id);
        }

        public void ChangeToTrueByGuide(int id)
        {
            _guideDal.ChangeToTrue(id);
        }

        public void TAdd(Guide entity)
        {
            _guideDal.Insert(entity);
        }

        public void TDelete(Guide entity)
        {
            _guideDal.Delete(entity);
        }

        public Guide TGetById(int id)
        {
            return _guideDal.GetById(id);
        }

        public List<Guide> TGetList()
        {
            return _guideDal.GetList();
        }

        public void TUpdate(Guide entity)
        {
            _guideDal.Update(entity);
        }
    }
}
