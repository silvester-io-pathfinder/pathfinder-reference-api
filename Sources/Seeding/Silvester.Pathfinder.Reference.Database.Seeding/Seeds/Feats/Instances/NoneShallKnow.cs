using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NoneShallKnow : Template
    {
        public static readonly Guid ID = Guid.Parse("6d3f71dd-bbd4-4996-9110-267723837dfa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "None Shall Know",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("58488813-3343-4bdc-827e-768150ce19b0"), Type = TextBlockType.Text, Text = "Even magical means have a hard time prying information from you. You gain (spell: nondetection) as an innate occult spell once per day, which can only be cast on yourself and is automatically heightened to half your level rounded up." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("01e006c8-6fff-4a74-84a5-40e0da780d39"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
