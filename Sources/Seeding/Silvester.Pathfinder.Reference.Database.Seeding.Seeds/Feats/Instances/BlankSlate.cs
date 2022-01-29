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
    public class BlankSlate : Template
    {
        public static readonly Guid ID = Guid.Parse("9fbfec5f-1d85-4b74-8d8d-bcf6e565d8cd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blank Slate",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("72639bf6-d3aa-4456-9977-46af055bc2b0"), Type = TextBlockType.Text, Text = $"Your deceptions confound even the most powerful mortal divinations. {ToMarkdownLink<Models.Entities.Trait>("Detection", Traits.Instances.Detection.ID)}, {ToMarkdownLink<Models.Entities.Trait>("revelation", Traits.Instances.Revelation.ID)}, and {ToMarkdownLink<Models.Entities.Trait>("scrying", Traits.Instances.Scrying.ID)} effects pass right over you, your possessions, and your auras, detecting nothing unless the detecting effect has a counteract level of 10 or higher. For example, {ToMarkdownLink<Models.Entities.Spell>("detect magic", Spells.Instances.DetectMagic.ID)} would still detect other magic in the area but not any magic on you, {ToMarkdownLink<Models.Entities.Spell>("true seeing", Spells.Instances.TrueSeeing.ID)} wouldn't reveal you, locate or scrying wouldn't find you, and so on." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("9b5ac2c0-babb-4f13-b326-b3cc70b72e30"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Deception.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("a44f7cbc-120f-4d50-97bf-1d1dc4dfdf65"), Traits.Instances.Rogue.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b5df543c-b14e-4421-8994-a3ebaf7b12de"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
