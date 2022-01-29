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
    public class Soulsight : Template
    {
        public static readonly Guid ID = Guid.Parse("7032cc48-4bed-4a4b-8447-bf43ff1a5c1b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Soulsight",
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
            yield return new TextBlock { Id = Guid.Parse("5bd6bd75-0e8a-485a-9967-f087958f1662"), Type = TextBlockType.Text, Text = $"The spiritual essence in your blood has opened your senses to the world beyond. You gain spiritsense as an imprecise sense with a range of 60 feet. Spiritsense allows you to sense the spirits of creatures within the listed range, including living creatures, most non-mindless undead, and haunts. As with your hearing and other imprecise senses, you still need to {ToMarkdownLink<Models.Entities.Action>("Seek", Actions.Instances.Seek.ID)} to locate an undetected creature. As spiritsense detects spiritual essence, not physical bodies, it can detect spirits projected by spells such as {ToMarkdownLink<Models.Entities.Spell>("project image", Spells.Instances.ProjectImage.ID)} or possessing otherwise soulless objects. It can't detect soulless bodies, constructs, or objects, and like most senses, it doesn't penetrate through solid objects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("2e1f8c08-c700-46e2-9352-2fe86a57d4ce"), "Bloodline that grants divine or occult spells.");
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("930af046-e00d-4355-9b98-00c84e598595"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
