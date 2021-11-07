using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShadowdancerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("6fb13bb7-63e8-46f7-8013-3d38045ec66c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shadowdancer Dedication",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the shadowdancer archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("956a81db-5691-4013-9a73-6caff4bb2796"), Type = TextBlockType.Text, Text = "You dedicate yourself to the shadows. Your coloring becomes gray and gloomy, your senses adjust to the darkness, and you can sneak through darkness with ease. You gain greater darkvision. You also gain a +2 circumstance bonus to Stealth checks when you are within dim light or darkness." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("6b9cb49e-30c9-43e7-b78d-73128075b5e2"), Proficiencies.Instances.Master.ID, Skills.Instances.Stealth.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("dba71464-6fbe-48ec-be1b-b978341e5fdb"), Proficiencies.Instances.Expert.ID, Skills.Instances.Performance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("75140783-90e5-4820-8134-7e70c6f04bf9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
