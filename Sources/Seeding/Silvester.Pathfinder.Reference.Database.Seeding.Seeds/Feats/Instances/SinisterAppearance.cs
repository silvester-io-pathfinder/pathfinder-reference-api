using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SinisterAppearance : Template
    {
        public static readonly Guid ID = Guid.Parse("859749d0-3024-4daa-8043-654eb4f37c4f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sinister Appearance",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("92e0babf-2154-48aa-b41c-ac0df316f798"), Type = TextBlockType.Text, Text = $"You possess horns, a tail, or red eyes, or could otherwise be mistaken for a tiefling. You gain the trained proficiency rank in Intimidation. If you would automatically become trained in Intimidation (from your background or class, for example), you instead become trained in a skill of your choice. You gain the {ToMarkdownLink<Models.Entities.Feat>("Intimidating Glare", Feats.Instances.IntimidatingGlare.ID)} skill feat, as well as a +2 circumstance bonus on Deception checks to {ToMarkdownLink<Models.Entities.SkillAction>("Impersonate", SkillActions.Instances.Impersonate.ID)} when pretending to be a version of yourself who is a tiefling." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("02456e56-acd8-449e-aa61-3b97b6da225b"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
