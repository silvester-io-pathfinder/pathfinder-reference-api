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
    public class Camouflage : Template
    {
        public static readonly Guid ID = Guid.Parse("fc08217c-ddc7-4ba5-ae6f-b63ac73e61ba");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Camouflage",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d6f6a05f-cb3a-4fb0-af68-de04605f4101"), Type = TextBlockType.Text, Text = $"You alter your appearance to blend in to the wilderness. In natural terrain, you can {ToMarkdownLink<Models.Entities.SkillAction>("Sneak", SkillActions.Instances.Sneak.ID)} even if you're observed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("2e045e6c-2723-46eb-99b6-feee35f36e72"), Proficiencies.Instances.Master.ID, Skills.Instances.Stealth.ID);
            builder.HaveSpecificFeat(Guid.Parse("f911e380-1147-455a-aab4-48b413eb3dc3"), Feats.Instances.ScoutDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Ranger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("58766fb1-2b73-480f-b237-bdd883de0298"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
