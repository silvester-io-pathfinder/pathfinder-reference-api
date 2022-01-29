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
    public class ChanneledSuccor : Template
    {
        public static readonly Guid ID = Guid.Parse("6983fb47-cb4d-423e-9217-4aac91a5651c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Channeled Succor",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1506c35c-48fc-44bb-8f80-8cc3244bfa47"), Type = TextBlockType.Text, Text = $"You can remove conditions with divine grace. You can sacrifice one {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} spell you've prepared in your extra slots from healing font to cast one of the following spells instead: {ToMarkdownLink<Models.Entities.Spell>("remove curse", Spells.Instances.RemoveCurse.ID)}, {ToMarkdownLink<Models.Entities.Spell>("remove disease", Spells.Instances.RemoveDisease.ID)}, {ToMarkdownLink<Models.Entities.Spell>("remove paralysis", Spells.Instances.RemoveParalysis.ID)}, or {ToMarkdownLink<Models.Entities.Spell>("restoration", Spells.Instances.Restoration.ID)}. The spell is heightened to the same level as the heal spell you sacrificed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineFont(Guid.Parse("726ffaca-191d-48ce-9aa6-9e378b48a9b5"), DivineFonts.Instances.Heal.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c6e6777f-9abb-4cb5-8c19-ec42d2c0b805"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
