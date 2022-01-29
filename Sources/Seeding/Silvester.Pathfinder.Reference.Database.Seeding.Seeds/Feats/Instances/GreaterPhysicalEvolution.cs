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
    public class GreaterPhysicalEvolution : Template
    {
        public static readonly Guid ID = Guid.Parse("e51fa698-d16c-4e1f-9730-557f9455dca7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Physical Evolution",
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
            yield return new TextBlock { Id = Guid.Parse("3dadcaa9-af0a-44e3-b7d3-4c14fa961a4d"), Type = TextBlockType.Text, Text = $"You hold a deep understanding of the innate fundamental structures of the physical world, and you can enforce your will upon that structure as far as your own blood is concerned. Once per day, you can use a sorcerer spell slot to cast any common polymorph battle form spell of the spell slot's level as if it were a signature spell in your repertoire." };
            yield return new TextBlock { Id = Guid.Parse("1314f69a-ecec-4cf8-8ef4-1c058e9b41b3"), Type = TextBlockType.Text, Text = $"If you have {ToMarkdownLink<Models.Entities.Feat>("Arcane Evolution", Feats.Instances.ArcaneEvolution.ID)}, you can also choose from any battle form spell in your spellbook. If you have {ToMarkdownLink<Models.Entities.Feat>("Primal Evolution", Feats.Instances.PrimalEvolution.ID)}, you can {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} listed in that feat using the extra spell slot the feat grants (instead of a sorcerer spell slot)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("d6a72847-1727-4366-acbb-2bc8d6a92531"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("c50240b3-c28a-4e16-ad2b-8364b6ee1873"), Feats.Instances.ArcaneEvolution.ID);
                or.HaveSpecificFeat(Guid.Parse("cc80b450-de11-473f-bb55-17c5d783e2f1"), Feats.Instances.PrimalEvolution.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Sorcerer.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd7a8a3e-058f-4723-aad2-48d234ac3eed"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
