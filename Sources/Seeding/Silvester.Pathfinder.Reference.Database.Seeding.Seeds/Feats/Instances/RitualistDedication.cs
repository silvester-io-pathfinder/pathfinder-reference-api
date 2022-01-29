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
    public class RitualistDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("76545197-3829-46bb-8fdf-a01ae6a352a7");

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
            yield return new TextBlock { Id = Guid.Parse("1388d6f9-30ce-46cf-a169-f59f0d50062b"), Type = TextBlockType.Text, Text = $"You have begun to master the difficult art of casting rituals. You gain a +2 circumstance bonus to all primary checks to perform a ritual. You learn two uncommon rituals with a level no higher than half your level; you must meet all prerequisites for casting the ritual to choose it. At 8th level and every 4 levels thereafter, you learn another uncommon ritual with a level no higher than half your level and for which you meet the prerequisites. You can cast these as the primary caster, but you can't teach them to anyone else or allow someone else to serve as primary caster unless they know the ritual as well." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("a3f673f3-0d15-4bef-8793-2b415477bdba"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("6d261444-2268-4b99-9376-d1b98996e6c9"), Proficiencies.Instances.Expert.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("87e634bc-91e4-41de-b469-6cbe0bfb0ccb"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("840defc4-de11-497b-becd-5ed6ce4cc314"), Proficiencies.Instances.Expert.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("69ba6157-260a-42dd-88a8-b58ef8425100"), Proficiencies.Instances.Expert.ID, Skills.Instances.Religion.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("15cc3588-f893-4fb0-b48b-8efc00ac3599"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("8fb18380-7124-4386-a01f-1175590f80e1"), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("35c58ebb-3744-406e-ac90-781d6635ec9f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
