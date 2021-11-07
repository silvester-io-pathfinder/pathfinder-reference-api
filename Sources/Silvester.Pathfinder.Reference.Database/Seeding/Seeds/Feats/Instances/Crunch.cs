using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Crunch : Template
    {
        public static readonly Guid ID = Guid.Parse("987fddde-222e-4330-a15e-1492bb2bb9b2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crunch",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fdbf918b-6088-4943-b4f0-7fa40861c0ba"), Type = TextBlockType.Text, Text = "Your jaws can crush bone and bite through armor. Your jaws unarmed attack deals 1d8 piercing damage instead of 1d6 and gains the (trait: grapple) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6268ae6-4548-4d47-98be-516f8b23bd08"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
