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
    public class VernaiTraining : Template
    {
        public static readonly Guid ID = Guid.Parse("cf1fe40c-8eca-4734-ac0a-0af6adcdc0e9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vernai Training",
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
            yield return new TextBlock { Id = Guid.Parse("89375c75-75a5-424d-82c6-e47ad9a6bf5c"), Type = TextBlockType.Text, Text = $"To resurrect a creature you've slain, a spellcaster must counteract your influence on its death. The DC of this check is equal to your class DC or spell DC, whichever is higher." };
            yield return new TextBlock { Id = Guid.Parse("df0ef7fc-b48f-446a-bd2c-62b48057084b"), Type = TextBlockType.Text, Text = $"In addition, add two 5th-level spells to your Red Mantis assassin spellbook – both spells must be chosen from the following options: {ToMarkdownLink<Models.Entities.Spell>("death ward", Spells.Instances.DeathWard.ID)}, {ToMarkdownLink<Models.Entities.Spell>("drop dead", Spells.Instances.DropDead.ID)}, {ToMarkdownLink<Models.Entities.Spell>("false vision", Spells.Instances.FalseVision.ID)}, {ToMarkdownLink<Models.Entities.Spell>("hallucination", Spells.Instances.Hallucination.ID)}, {ToMarkdownLink<Models.Entities.Spell>("illusory scene", Spells.Instances.IllusoryScene.ID)}, {ToMarkdownLink<Models.Entities.Spell>("mind probe", Spells.Instances.MindProbe.ID)}, or {ToMarkdownLink<Models.Entities.Spell>("sending", Spells.Instances.Sending.ID)}. You gain a 5th-level spell slot that you can use to prepare a spell from your Red Mantis assassin spellbook." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1e69011a-3007-495e-b5b0-2fca34ee4f10"), Feats.Instances.AchaekeksGrip.ID);
            builder.HaveSpecificFeat(Guid.Parse("d622401b-6306-4c3e-9838-7c2860d13588"), Feats.Instances.AdvancedRedMantisMagic.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("defed41c-fbe1-4f86-aee4-4d13b732cb6a"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d027d6bf-885f-4bee-9824-04cfd381ecad"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
