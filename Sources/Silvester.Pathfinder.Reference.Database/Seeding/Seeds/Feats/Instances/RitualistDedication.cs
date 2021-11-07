using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RitualistDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("f494791e-29e9-4775-bd5d-b3e21899a8c3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ritualist Dedication",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the ritualist archetype. If you retrain out of this feat, you lose the rituals learned from it.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("34c950ce-e7ff-493c-930d-1959255209c4"), Type = TextBlockType.Text, Text = "You have begun to master the difficult art of casting rituals. You gain a +2 circumstance bonus to all primary checks to perform a ritual. You learn two uncommon rituals with a level no higher than half your level; you must meet all prerequisites for casting the ritual to choose it. At 8th level and every 4 levels thereafter, you learn another uncommon ritual with a level no higher than half your level and for which you meet the prerequisites. You can cast these as the primary caster, but you can’t teach them to anyone else or allow someone else to serve as primary caster unless they know the ritual as well." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("8e3c2dfc-8cc8-47bd-877f-1b54347b2f80"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("86910bb7-b944-4220-bd5e-f82e4768ac9d"), Proficiencies.Instances.Expert.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("2025570c-0494-4498-a149-756533dbb93c"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("aaeca335-3705-4085-bd6b-50c1711f1d00"), Proficiencies.Instances.Expert.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("fb4533e2-ec18-41b8-a510-650cce23249d"), Proficiencies.Instances.Expert.ID, Skills.Instances.Religion.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2daebd30-a5c8-43de-87c2-f1022c9dc4f6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
