using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeepLore : Template
    {
        public static readonly Guid ID = Guid.Parse("754b141c-b399-441c-977f-03cb8c8dc4c0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deep Lore",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0811b636-6c1f-4081-870d-99c985f450b0"), Type = TextBlockType.Text, Text = "Your repertoire is vast, containing far more spells than usual. Add one spell to your repertoire of each level you can cast." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("d8fbfa4c-0fb8-4b56-a8cd-6a2dd823f45c"), Muses.Instances.Enigma.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("743df885-abb2-42d3-b6e3-7af142d0794a"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Occultism.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c399e7d-ecec-4e2a-b9f8-55a2769d33c5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
