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
    public class PartyCrasher : Template
    {
        public static readonly Guid ID = Guid.Parse("bd54dd54-90cb-45c6-ac4f-301d26d0876a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Party Crasher",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b0ba3031-a552-4ff3-b071-8f0187ac2329"), Type = TextBlockType.Text, Text = $"You attend all the fashionable society parties, no matter how exclusive they might be. Any time you encounter a social event you would ordinarily be denied access to, such as a coronation, royal gala, or other society function, you can spend 1d4 hours to secure entry without the need for a skill check. You find invitations, invitees looking for fashionable dates, temporary jobs with the caterers, event staff willing to look the other way, or some other mode of access for yourself and your allies. This ability doesn't apply to secret events or other small private gatherings with no staff, dates, or outsiders involved." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("51213399-d61e-4b35-980f-ae51732e4a34"), Feats.Instances.DandyDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("210ece6f-790f-43e8-893f-2b8b1cd4a9a6"), Proficiencies.Instances.Master.ID, Skills.Instances.Society.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3cef931b-4a27-4627-bc56-dd6ec0df14ad"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
