using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreaterMentalEvolution : Template
    {
        public static readonly Guid ID = Guid.Parse("25ac48f0-26bf-45c6-922a-326aa1aa3e36");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Mental Evolution",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5a696c09-f760-4ba8-9cb6-17d5177fd2eb"), Type = TextBlockType.Text, Text = "Your bloodline’s deep connection to mental essence greatly enhances your spell repertoire. Add one spell to your spell repertoire for each spell level you can cast." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("c6456f88-eaf8-4225-9cc6-a62b0293a681"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("c36a2299-2f45-455a-845f-fae564f6d8d4"), Feats.Instances.ArcaneEvolution.ID);
                or.HaveSpecificFeat(Guid.Parse("090592fd-4e16-4495-9c27-06fe2c00076b"), Feats.Instances.OccultEvolution.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e2524eaf-2716-4e74-b6b7-2c3d70353ec9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
