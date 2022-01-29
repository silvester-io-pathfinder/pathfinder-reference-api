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
    public class SteelSkin : Template
    {
        public static readonly Guid ID = Guid.Parse("3a78b27a-1e93-4e9b-ad29-127bec0b34be");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steel Skin",
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
            yield return new TextBlock { Id = Guid.Parse("a85bc982-106b-4e3d-ae3a-496e86336d2e"), Type = TextBlockType.Text, Text = $"You wear your armor like a second skin. You can rest normally while wearing medium armor. If you are a master in heavy armor, you can also rest normally while wearing heavy armor." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("a00c4eab-bd07-4303-871c-92e53892e5a3"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            builder.HaveSpecificFeat(Guid.Parse("4dac07a1-46cf-4acb-abea-b2c84f674dad"), Feats.Instances.SentinelDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("c7afff29-b72b-4a36-8dbe-68ac18639257"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("664a5f4d-d278-445d-a3a1-6596280515ae"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("769e934f-2bb3-44ee-aab2-36ad0c95239d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
