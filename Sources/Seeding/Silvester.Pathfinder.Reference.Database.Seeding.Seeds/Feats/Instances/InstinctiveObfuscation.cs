using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InstinctiveObfuscation : Template
    {
        public static readonly Guid ID = Guid.Parse("f090608d-7062-4cc8-93e7-3b570a9466c7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Instinctive Obfuscation",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are attacked by a foe.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0f814793-1949-41c4-9005-8f4e982319fc"), Type = TextBlockType.Text, Text = $"The magic within you manifests as a natural reaction to threats. You gain the effects of {ToMarkdownLink<Models.Entities.Spell>("mirror image", Spells.Instances.MirrorImage.ID)} but with two images instead of three. The tradition of this action matches the tradition of your gnome ancestry options." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("b5f02954-a529-42ab-8259-47a9f69118d9"), "at least one arcane or occult innate spell gained from a gnome heritage or gnome ancestry feat");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("346bb1e6-7070-49ec-9d17-eb161f7ca718"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
