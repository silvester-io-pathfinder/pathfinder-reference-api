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
    public class AuraOfVengeance : Template
    {
        public static readonly Guid ID = Guid.Parse("97c337bc-1654-43d1-bcc2-999ebc42ce26");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aura of Vengeance",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("43f7cc8e-f76a-41e5-b00a-178f2029e588"), Type = TextBlockType.Text, Text = $"When you call upon others to take retribution, you also guide their aim. When you use {ToMarkdownLink<Models.Entities.Feat>("Retributive Strike", Feats.Instances.RetributiveStrike.ID)}, your allies who make {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} take only a -2 penalty, instead of a -5 penalty." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificCause(Guid.Parse("d3be71f6-c604-481f-bd66-56bd7b26173c"), Causes.Instances.Paladin.ID);
            builder.HaveSpecificFeat(Guid.Parse("074a08be-0350-4137-8034-19a2f6d30de2"), Feats.Instances.VengefulOath.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Champion.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c016480c-dd32-49a8-88e8-dab76dcb1ce8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
