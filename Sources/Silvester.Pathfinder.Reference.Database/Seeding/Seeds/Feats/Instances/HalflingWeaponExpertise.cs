using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HalflingWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("a58ca131-3efa-415a-a9d1-83829c945d83");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Halfling Weapon Expertise",
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
            yield return new TextBlock { Id = Guid.Parse("f2a05b54-5fd8-43b0-b6de-c778a17c9e54"), Type = TextBlockType.Text, Text = "Your halfling affinity blends with your class training, granting you great skill with halfling weapons. Whenever you gain a class feature that grants you expert or greater proficiency in a given weapon or weapons, you also gain that proficiency in the sling, halfling sling staff, shortsword, and all halfling weapons in which you are trained." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificAncestry(Guid.Parse("d659d1fd-3db9-4456-ae55-58123953793a"), Ancestries.Instances.Halfling.ID);
            builder.HaveSpecificFeat(Guid.Parse("20338eb6-bccb-4aa7-bf4e-b2794cc6e6f1"), Feats.Instances.WeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1375e614-712c-4315-b082-a98e0c162314"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
