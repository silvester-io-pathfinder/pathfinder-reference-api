using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TattooArtist : Template
    {
        public static readonly Guid ID = Guid.Parse("07760a11-e930-4bf2-a23e-1a7170619e99");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tattoo Artist",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eb707252-27f6-4bf0-a565-699e4436db61"), Type = TextBlockType.Text, Text = "You can craft tattoos, including magical tattoos. When you select this feat, you gain the formulas for four common magical tattoos of 2nd level or lower. You gain a +1 circumstance bonus to Crafting checks to (action: Craft) tattoos. If you’re a master in Crafting, this bonus increases to +2." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("16956d7e-da18-4d9e-946b-29c6ef5ade50"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("48cf80ce-f829-4e1a-ade6-84742af23e6a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
