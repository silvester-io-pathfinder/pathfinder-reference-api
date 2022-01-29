using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TenguFeatherFan : Template
    {
        public static readonly Guid ID = Guid.Parse("3c6cb563-1b4d-43d8-b514-72b50bd0147f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tengu Feather Fan",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("31571ffc-681d-45a5-a6bf-d6f4459ffaf2"), Type = TextBlockType.Text, Text = $"You've learned to bind some of your feathers together into a fan to focus your ancestral magic. You gain a {ToMarkdownLink<Models.Entities.Feat>("tengu feather fan", Feats.Instances.TenguFeatherFan.ID)}: a magic item of light Bulk with a level equal to your level and the {ToMarkdownLink<Models.Entities.Trait>("evocation", Traits.Instances.Evocation.ID)} and {ToMarkdownLink<Models.Entities.Trait>("primal", Traits.Instances.Primal.ID)} traits. You (and only you) can use the {ToMarkdownLink<Models.Entities.Feat>("tengu feather fan", Feats.Instances.TenguFeatherFan.ID)} to cast tengu magic. If your fan is lost or destroyed, you can create a replacement during your daily preparations; if you do so, your previous fan falls apart into mundane feathers. Further feats might grant you additional activations of your {ToMarkdownLink<Models.Entities.Feat>("tengu feather fan", Feats.Instances.TenguFeatherFan.ID)}, but you can never have more than three activations per day, no matter how many such feats you have. The DC for spells you cast with your {ToMarkdownLink<Models.Entities.Feat>("tengu feather fan", Feats.Instances.TenguFeatherFan.ID)} is your class DC or spell DC, whichever is higher." };
            yield return new TextBlock { Id = Guid.Parse("35eafbbc-ee46-45a7-8562-36edbf89fb8f"), Type = TextBlockType.Text, Text = $"You can cast the 1st-level {ToMarkdownLink<Models.Entities.Spell>("gust of wind", Spells.Instances.GustOfWind.ID)} spell by activating your {ToMarkdownLink<Models.Entities.Feat>("tengu feather fan", Feats.Instances.TenguFeatherFan.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("20cc881d-4430-40ea-84a3-5d209e41228a"), Type = TextBlockType.Text, Text = $"~ Activate: {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)}; **Frequency** once per day; **Effect** You cast one of the spells contained in your tengu feather fan. Activating the fan takes the spell's normal number of actions. You can also Activate the fan to cast a cantrip you've gained from a heritage or ancestry feat; this activation doesn't count against the fan's uses per day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4b9c76f8-d627-41c2-b707-e12e86054e64"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
