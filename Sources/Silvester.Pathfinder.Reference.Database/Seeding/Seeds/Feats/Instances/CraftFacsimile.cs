using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CraftFacsimile : Template
    {
        public static readonly Guid ID = Guid.Parse("1d89065e-cd63-4ad7-9f62-b2618097980c");

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
            yield return new TextBlock { Id = Guid.Parse("aa77b58b-ffc8-423c-9d00-007095d1675a"), Type = TextBlockType.Text, Text = "You&#39;re renowned for your ability to recover important items, whether they&#39;re from a long-abandoned temple or a thieves&#39; den, and sometimes that requires creating a stand-in. You can spend 1 minute to assemble a facsimile of an object of no more than 1 Bulk that you can see from available materials. The facsimile has the same shape and Bulk as the replaced object and can pass as the object if not examined. A creature familiar with the original who examines the object automatically realizes that it is a fake. A creature not familiar with the original can still tell it was a hastily jury-rigged stand-in of some kind, but they might not know the object was supposed to be something else." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("0ccedca2-651a-4066-80f0-b99504bc17cf"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
            builder.HaveSpecificFeat(Guid.Parse("dba2026d-3c28-49ac-addb-f5ab28c0e522"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3547ced-0f6f-4f6c-bb58-14e85021fd22"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
