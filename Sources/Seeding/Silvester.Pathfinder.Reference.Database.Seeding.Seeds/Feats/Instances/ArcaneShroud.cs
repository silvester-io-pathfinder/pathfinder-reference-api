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
    public class ArcaneShroud : Template
    {
        public static readonly Guid ID = Guid.Parse("7936211d-2fb2-4d53-a755-7f82e81725f5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Shroud",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per turn"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b5116679-815c-43bc-9686-daa6edece8a9"), Type = TextBlockType.Text, Text = $"Your spell has a powerful aftereffect, briefly granting you a certain spell depending on the spell you cast. You use {ToMarkdownLink<Models.Entities.Feat>("Arcane Cascade", Feats.Instances.ArcaneCascade.ID)} and are subject to an additional aftereffect spell depending on the school of your most recent spell. This aftereffect spell's duration lasts until the end of your next turn or its normal duration, whichever is longer. Using Arcane Shroud again ends any existing spell you gained from Arcane Shroud." };
            yield return new TextBlock { Id = Guid.Parse("5fc871e1-9301-4057-b74b-ab90a43f12ee"), Type = TextBlockType.Enumeration, Text = $" Abjuration: {ToMarkdownLink<Models.Entities.Spell>("stoneskin", Spells.Instances.Stoneskin.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("b622edbe-2428-4996-ada9-32486a9b74fb"), Type = TextBlockType.Enumeration, Text = $" Conjuration: {ToMarkdownLink<Models.Entities.Spell>("blink", Spells.Instances.Blink.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("2fe99cee-2b64-4fd5-aedb-d3cdd3e6df96"), Type = TextBlockType.Enumeration, Text = $" Divination: {ToMarkdownLink<Models.Entities.Spell>("see invisibility", Spells.Instances.SeeInvisibility.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("8d3ac3ba-51bf-435a-919e-df440e13cb27"), Type = TextBlockType.Enumeration, Text = $" Enchantment: {ToMarkdownLink<Models.Entities.Spell>("heroism", Spells.Instances.Heroism.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("8c6dbdbc-22e6-4088-af51-c0be4211b811"), Type = TextBlockType.Enumeration, Text = $" Evocation: {ToMarkdownLink<Models.Entities.Spell>("fire shield", Spells.Instances.FireShield.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("0138fd09-e4d9-4302-9eab-1943c48a6ca4"), Type = TextBlockType.Enumeration, Text = $" Illusion: {ToMarkdownLink<Models.Entities.Spell>("invisibility", Spells.Instances.Invisibility.ID)} (ends after a hostile action, as normal)" };
            yield return new TextBlock { Id = Guid.Parse("aac2b85e-4b62-447b-b4db-cb6cf4020189"), Type = TextBlockType.Enumeration, Text = $" Necromancy: {ToMarkdownLink<Models.Entities.Spell>("false life", Spells.Instances.FalseLife.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("16994ef5-fba3-498b-96b0-a12d8731de27"), Type = TextBlockType.Enumeration, Text = $" Transmutation: {ToMarkdownLink<Models.Entities.Spell>("fleet step", Spells.Instances.FleetStep.ID)}" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9546019c-ca30-49d8-8b6f-e16a3d8271fc"), Feats.Instances.ArcaneCascade.ID);
            builder.HaveSpecificFeat(Guid.Parse("399dced1-5376-4de5-9485-af757e1df9ff"), Feats.Instances.Spellstrike.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("29c290a6-d8f7-4bb2-967f-761dffce8a70"), Traits.Instances.Magus.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("72af669b-b08a-4741-9026-0ae73d6cc14c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
