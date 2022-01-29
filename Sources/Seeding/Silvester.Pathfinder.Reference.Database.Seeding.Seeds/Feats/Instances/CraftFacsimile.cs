using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CraftFacsimile : Template
    {
        public static readonly Guid ID = Guid.Parse("622a0e3c-55ea-4bda-94e8-b3e8ca189546");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Craft Facsimile",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a8b96a8a-7638-4842-ad18-a7fe23b84a96"), Type = TextBlockType.Text, Text = $"You're renowned for your ability to recover important items, whether they're from a long-abandoned temple or a thieves' den, and sometimes that requires creating a stand-in. You can spend 1 minute to assemble a facsimile of an object of no more than 1 Bulk that you can see from available materials. The facsimile has the same shape and Bulk as the replaced object and can pass as the object if not examined. A creature familiar with the original who examines the object automatically realizes that it is a fake. A creature not familiar with the original can still tell it was a hastily jury-rigged stand-in of some kind, but they might not know the object was supposed to be something else." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("7d4a7e3b-3ac1-4245-ab35-47586f4f3616"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
            builder.HaveSpecificFeat(Guid.Parse("5cd0ccdb-a570-4413-8363-45eec58182fd"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fcbecbcc-637a-4953-882a-78b1490f9ad5"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
