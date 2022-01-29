using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RainOfEmbersStance : Template
    {
        public static readonly Guid ID = Guid.Parse("ca167faf-a0d1-4b43-9215-acebccb1d6a7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rain of Embers Stance",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f620c273-b486-45aa-97cb-8bfc3e136e29"), Type = TextBlockType.Text, Text = $"You enter the stance of an enraged phoenix, holding your fingers as rigid as deadly talons while moving with quick, flickering gestures that dance with biting flames. The only {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} you can make are fire talon {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)}. These deal 1d4 fire damage; are in the brawling group; and have the {ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)}, {ToMarkdownLink<Models.Entities.Trait>("finesse", Traits.Instances.Finesse.ID)}, {ToMarkdownLink<Models.Entities.Trait>("fire", Traits.Instances.Fire.ID)}, {ToMarkdownLink<Models.Entities.Trait>("nonlethal", Traits.Instances.Nonlethal.ID)}, and {ToMarkdownLink<Models.Entities.Trait>("unarmed", Traits.Instances.Unarmed.ID)} traits." };
            yield return new TextBlock { Id = Guid.Parse("5932e63e-4531-4fa6-bbd0-b6a207dcd96e"), Type = TextBlockType.Text, Text = $"While in Rain of Embers Stance, you gain a +1 status bonus to AC and fire resistance equal to half your level (minimum 1)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("665a92c9-aeb4-4717-ac42-b4339e8f9687"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
