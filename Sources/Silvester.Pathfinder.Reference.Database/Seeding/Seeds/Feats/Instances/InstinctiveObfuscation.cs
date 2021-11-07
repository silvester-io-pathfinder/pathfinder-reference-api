using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InstinctiveObfuscation : Template
    {
        public static readonly Guid ID = Guid.Parse("cd299f6b-d0f5-423c-b952-599691c7e456");

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
            yield return new TextBlock { Id = Guid.Parse("5f72b6dd-bde8-4ade-af36-220cc80b5e0d"), Type = TextBlockType.Text, Text = "The magic within you manifests as a natural reaction to threats. You gain the effects of (spell: mirror image) but with two images instead of three. The tradition of this action matches the tradition of your gnome ancestry options." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("3894f73e-ba42-4109-9473-3ff1b124293f"), "at least one arcane or occult innate spell gained from a gnome heritage or gnome ancestry feat");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c023d552-17fd-465a-a5ef-4dc4b2ec7588"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
