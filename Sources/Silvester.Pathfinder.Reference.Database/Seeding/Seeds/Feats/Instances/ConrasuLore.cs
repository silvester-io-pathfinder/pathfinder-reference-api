using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConrasuLore : Template
    {
        public static readonly Guid ID = Guid.Parse("0fdbcee3-f2bd-4fd4-9ac8-8c2224aff3ab");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Conrasu Lore",
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
            yield return new TextBlock { Id = Guid.Parse("36ab82f8-af98-4520-93da-8b6fcb4745ff"), Type = TextBlockType.Text, Text = "You have learned about your history and your people from shapers. You gain the trained proficiency rank in Crafting and Occultism. If you would automatically become trained in one of those skills (from your background or class, for example), you instead become trained in a skill of your choice. You also become trained in Conrasu Lore." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f1106c5e-3b9f-4096-9241-ed4dc9eb3a31"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
