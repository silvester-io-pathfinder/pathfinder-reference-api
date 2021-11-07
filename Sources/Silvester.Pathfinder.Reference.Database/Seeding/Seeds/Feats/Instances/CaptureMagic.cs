using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CaptureMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("583fa9e8-efcb-4445-a132-21147eb33bd2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Capture Magic",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You succeed at your save against a foe's harmful spell, or a foe fails a spell attack roll against you from a harmful spell.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7fa88fdc-27a1-4ae8-accc-fab4a0d2de4a"), Type = TextBlockType.Text, Text = "When you resist a spell, you capture some of its magic for your own use. You enter your (feat: Arcane Cascade) stance, using the triggering spell to determine what damage type your (feat: Arcane Cascade) deals. Alternatively, if you’re already in (feat: Arcane Cascade), you can instead amplify its effects temporarily. Until the end of your next turn, you gain a +2 status bonus to the damage from your (feat: Arcane Cascade)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f2f613ef-3468-4c32-9e49-de38aa89537d"), Feats.Instances.ArcaneCascade.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ad8efac-329c-49cc-8923-db87242967f8"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
