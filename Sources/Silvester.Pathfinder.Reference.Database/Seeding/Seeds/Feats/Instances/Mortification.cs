using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Mortification : Template
    {
        public static readonly Guid ID = Guid.Parse("b6be9b23-bbb3-431c-8e9f-af67efa91f94");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mortification",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f7404e8f-df05-4366-b192-21b09516b040"), Type = TextBlockType.Text, Text = "Your reckonings have prepared your body for physical punishment. Choose bludgeoning, piercing, or slashing damage, based on the nature of your physical reckonings. You gain resistance to the chosen damage type equal to your number of class feats from the Hellknight Armiger archetype and other Hellknight archetypes." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("568683ee-6a32-49b4-8253-b2b853caa96b"), Feats.Instances.HellknightArmigerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68e9108e-fc3e-4886-987d-99e17e594a20"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
