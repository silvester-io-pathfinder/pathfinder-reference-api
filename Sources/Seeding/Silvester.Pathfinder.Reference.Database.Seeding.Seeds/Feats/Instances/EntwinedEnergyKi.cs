using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EntwinedEnergyKi : Template
    {
        public static readonly Guid ID = Guid.Parse("426aa6de-7702-4db0-935d-65e38ddbc80c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Entwined Energy Ki",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "At the GM's discretion, this feat can alter other ki spells.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cd9e918d-df5b-472f-8e06-0a9c115ca2a7"), Type = TextBlockType.Text, Text = $"You can transform your inner power into a type of energy to empower your ki abilities. When you gain this feat, choose either acid, cold, electricity, fire, or sonic damage. When you cast {ToMarkdownLink<Models.Entities.Spell>("ki blast", Spells.Instances.KiBlast.ID)}, you can choose to have the spell deal the type of damage you chose instead of force damage. When you cast {ToMarkdownLink<Models.Entities.Spell>("ki form", Spells.Instances.KiForm.ID)} or {ToMarkdownLink<Models.Entities.Spell>("ki strike", Spells.Instances.KiStrike.ID)}, add the type of damage you chose to the list of damage types you can select for the spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d1dbb0d1-2839-4a91-9be2-f150c528fb97"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
