﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZTPwords.Models;

namespace ZTPwords.Logic
{
    public class AnswersDecoratorListMix : AnswersDecorator
    {
        public AnswersDecoratorListMix(IAnswers _answes) : base(_answes)
        {
        }

        public override List<Word> getAnswerList()
        {
            List<Word> temp = answers.getAnswerList();
            Random.Org.Random rand = new Random.Org.Random();
            int size = temp.Count;
            List<Word> temp2= new List<Word>();
            int tempSize = size;
            for (int i=0;i< tempSize; i++)
            {
                int randd = rand.Next(0, size);
                temp2.Add(temp[randd]);
                temp.RemoveAt(randd);
                size = temp.Count;
            }
            return temp2;
        }
    }

}