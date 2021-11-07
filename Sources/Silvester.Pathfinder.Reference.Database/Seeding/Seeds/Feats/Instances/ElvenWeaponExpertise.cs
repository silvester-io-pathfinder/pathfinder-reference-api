using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElvenWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("e453f892-8a24-495f-95b1-0322fc53b58a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elven Weapon Expertise",
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
            yield return new TextBlock { Id = Guid.Parse("f34350b4-ef29-4801-91ff-9293bc182f68"), Type = TextBlockType.Text, Text = "Your elven affinity blends with your class training, granting you great skill with elven weapons. Whenever you gain a class feature that grants you expert or greater proficiency in certain weapons, you also gain that proficiency in longbows, composite longbows, longswords, rapiers, shortbows, composite shortbows, and all elf weapons in which you are trained." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("145e1ce4-e0c7-409f-af2c-26fa3132cbdd"), Feats.Instances.ElvenWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a90c4216-0001-4042-875a-6bfd66320c4a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
