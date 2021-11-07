using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EntwinedEnergyKi : Template
    {
        public static readonly Guid ID = Guid.Parse("bff35a47-1c30-4b8a-838e-56887eb0d282");

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
            yield return new TextBlock { Id = Guid.Parse("47e6a747-8fa0-4297-9fc2-eae00cb74b65"), Type = TextBlockType.Text, Text = "You can transform your inner power into a type of energy to empower your ki abilities. When you gain this feat, choose either acid, cold, electricity, fire, or sonic damage. When you cast (spell: ki blast), you can choose to have the spell deal the type of damage you chose instead of force damage. When you cast (spell: ki form) or (spell: ki strike), add the type of damage you chose to the list of damage types you can select for the spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b8d170e8-1da9-4468-8db7-3d7fbc908482"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
