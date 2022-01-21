using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BondConversion : Template
    {
        public static readonly Guid ID = Guid.Parse("460f45f6-9d79-4a9f-b218-f9c56134e4d6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bond Conversion",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dfa66aa3-2911-47ed-b6c7-ead25390b156"), Type = TextBlockType.Text, Text = $"By carefully manipulating the arcane energies stored in your bonded item as you drain it, you can conserve just enough power to cast another, slightly weaker spell. If the next action you use is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} using the energy from {ToMarkdownLink<Models.Entities.Feat>("Drain Bonded Item", Feats.Instances.DrainBondedItem.ID)}, you gain an extra use of {ToMarkdownLink<Models.Entities.Feat>("Drain Bonded Item", Feats.Instances.DrainBondedItem.ID)}. You must use this extra use of {ToMarkdownLink<Models.Entities.Feat>("Drain Bonded Item", Feats.Instances.DrainBondedItem.ID)} before the end of your next turn or you lose it, and you can use this additional use only to cast a spell 2 or more levels lower than the first spell cast with {ToMarkdownLink<Models.Entities.Feat>("Drain Bonded Item", Feats.Instances.DrainBondedItem.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("1c3b9e9a-571e-492b-8cdf-5f22208e0fff"), ClassFeatures.Wizards.ArcaneBond.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e58824dd-9918-4029-a72a-af083d7eaa6b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
