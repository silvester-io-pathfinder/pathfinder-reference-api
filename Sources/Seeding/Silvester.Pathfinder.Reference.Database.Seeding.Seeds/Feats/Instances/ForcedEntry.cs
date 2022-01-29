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
    public class ForcedEntry : Template
    {
        public static readonly Guid ID = Guid.Parse("de87739b-4064-400c-9680-ad879df8b97e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Forced Entry",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("546f2391-ec1c-4c16-ae65-20b12fe1acd2"), Type = TextBlockType.Text, Text = $"You are trained to preserve the archaeological value of your location when entering. You don't take a penalty to {ToMarkdownLink<Models.Entities.SkillAction>("Force Open", SkillActions.Instances.ForceOpen.ID)} doors, windows, or containers without a {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("crowbar", Items.AdventuringGears.Instances.Crowbar.ID)}. If you roll a success on a check to {ToMarkdownLink<Models.Entities.SkillAction>("Force Open", SkillActions.Instances.ForceOpen.ID)}, you get a critical success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e4735a2e-4b06-476c-999a-28b9ad6f4259"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
            builder.HaveSpecificFeat(Guid.Parse("be5b2ff1-dac9-4251-a8c4-05d242a47adb"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("9fd2c87e-7b03-4617-9e91-50c034797aca"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("ae2accb3-788d-463d-808e-b3676aabe480"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ac1b8a1-b6df-4bec-bec4-3dfac2faa055"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
