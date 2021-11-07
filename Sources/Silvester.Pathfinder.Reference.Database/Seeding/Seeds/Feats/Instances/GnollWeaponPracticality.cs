using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GnollWeaponPracticality : Template
    {
        public static readonly Guid ID = Guid.Parse("330a59d4-314b-4986-84e6-a6d3f9e7cb0f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gnoll Weapon Practicality",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("529c1970-e509-4d43-b580-6f4a4e1b19cb"), Type = TextBlockType.Text, Text = "Whenever you critically hit using (item: flails | Flail), (item: khopeshes | Khopesh), (item: mambeles | Mambele), (item: spears | Spear), and (item: war flails | War Flail), you apply the weapon’s critical specialization effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e0ceb812-ba72-421e-8c9c-de03459862c5"), Feats.Instances.GnollWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a2cde48c-a5d1-4c5f-af1e-31487db0bd26"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
